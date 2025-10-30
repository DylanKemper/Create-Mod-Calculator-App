using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Create_Mod_Calculator_App
{
    public partial class MainForm : Form
    {
        private List<IMachine> machines = new List<IMachine>();
        private IMachine selectedMachine;
        private bool isUpdating = false;

        public MainForm()
        {
            InitializeComponent();
            machines.Add(new MechanicalPress());
            cmbMachines.DataSource = machines;
            cmbMachines.DisplayMember = "Name";

            selectedMachine = cmbMachines.SelectedItem as IMachine;
            UpdateFieldAvailability();
        }

        private void txtItemsPerSec_TextChanged(object sender, EventArgs e)
        {
            UpdateCalculation("ItemsPerSec", txtItemsPerSec.Text, "RPM", txtRPM);
        }

        private void txtRPM_TextChanged(object sender, EventArgs e)
        {
            UpdateCalculation("RPM", txtRPM.Text, "ItemsPerSec", txtItemsPerSec);
        }

        private void UpdateCalculation(string inputVariable, string inputText, string outputVariable, TextBox outputTextBox)
        {
            if (isUpdating || selectedMachine == null || string.IsNullOrWhiteSpace(inputText))
                return;

            if (!double.TryParse(inputText, out double inputValue))
                return;

            try
            {
                isUpdating = true;

                var inputs = new Dictionary<string, double> { { inputVariable, inputValue } };
                double result = selectedMachine.Solve(outputVariable, inputs);
                outputTextBox.Text = $"{result:F2}";

                // Clear any previous error styling
                outputTextBox.BackColor = System.Drawing.SystemColors.Window;
            }
            catch (Exception ex)
            {
                outputTextBox.BackColor = System.Drawing.Color.LightPink;
                outputTextBox.Text = "RPM limited to 256";
            }
            finally
            {
                isUpdating = false;
            }
        }


        private void comboBoxMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMachine = cmbMachines.SelectedItem as IMachine;
            // Update available fields
        }

        private void UpdateFieldAvailability()
        {
            if (selectedMachine == null) return;

            var requiredInputs = selectedMachine.RequiredInputs;

            // Enable/disable textboxes based on machine requirements
            txtRPM.Enabled = requiredInputs.Contains("RPM");
            txtItemsPerSec.Enabled = requiredInputs.Contains("ItemsPerSec");
            txtStackSize.Enabled = requiredInputs.Contains("StackSize");

            // Update visual styling for disabled fields
            UpdateFieldStyling(txtRPM, txtRPM.Enabled);
            UpdateFieldStyling(txtItemsPerSec, txtItemsPerSec.Enabled);
            UpdateFieldStyling(txtStackSize, txtStackSize.Enabled);
        }
        private void UpdateFieldStyling(TextBox textBox, bool enabled)
        {
            if (enabled)
            {
                textBox.BackColor = System.Drawing.SystemColors.Window;
                textBox.ForeColor = System.Drawing.SystemColors.WindowText;
            }
            else
            {
                textBox.BackColor = System.Drawing.SystemColors.Control;
                textBox.ForeColor = System.Drawing.SystemColors.GrayText;
                textBox.Text = ""; // Clear disabled fields
            }
        }

        private void ClearAllFields()
        {
            txtRPM.Clear();
            txtItemsPerSec.Clear();
            txtStackSize.Clear();

            // Reset background colors
            txtRPM.BackColor = System.Drawing.SystemColors.Window;
            txtItemsPerSec.BackColor = System.Drawing.SystemColors.Window;
            txtStackSize.BackColor = System.Drawing.SystemColors.Window;
        }
    }
}
