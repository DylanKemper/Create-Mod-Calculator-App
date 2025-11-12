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
        private Dictionary<string, TextBox> inputTextBoxes;
        private bool isUpdating = false;

        public MainForm()
        {
            InitializeComponent();
            inputTextBoxes = new Dictionary<string, TextBox>
            {
                { "RPM", txtRPM },
                { "ItemsPerSec", txtItemsPerSec },
                { "StackSize", txtStackSize },
                { "RecipeDuration", txtRecipeDuration },
                { "InputDelay", txtInputDelay }
            };

            machines.Add(new MechanicalPress());
            machines.Add(new CrushingWheel());
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

        private void UpdateCalculation(string changedValue, string inputText, string outputVariable, TextBox outputTextBox)
        {
            if (isUpdating || selectedMachine == null || string.IsNullOrWhiteSpace(inputText))
                return;

            if (!double.TryParse(inputText, out double parsedValue))
                return;

            try
            {
                isUpdating = true;

                var inputs = new Dictionary<string, double>();

                // Collect all current input values
                foreach (string varName in selectedMachine.RequiredInputs)
                {
                    if (varName == outputVariable)
                        continue;

                    if (inputTextBoxes.TryGetValue(varName, out var textBox))
                    {
                        if (double.TryParse(textBox.Text, out double val))
                            inputs[varName] = val;
                    }
                }

                // Add the recently changed value
                inputs[changedValue] = parsedValue;

                // Ensure all required inputs (except the one we’re solving for) are available
                bool allInputsAvailable = selectedMachine.RequiredInputs
                    .Where(v => v != outputVariable)
                    .All(v => inputs.ContainsKey(v));

                if (!allInputsAvailable)
                    return;

                // Compute and display the result
                double result = selectedMachine.Solve(outputVariable, inputs);
                outputTextBox.Text = $"{result:F2}";
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


        private void cmbMachines_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedMachine = cmbMachines.SelectedItem as IMachine;
            UpdateFieldAvailability();
            ClearAllFields();
        }

        private void UpdateFieldAvailability()
        {
            if (selectedMachine == null) return;

            var requiredInputs = selectedMachine.RequiredInputs;

            // Enable/disable textboxes based on machine requirements
            txtRPM.Enabled = requiredInputs.Contains("RPM");
            txtItemsPerSec.Enabled = requiredInputs.Contains("ItemsPerSec");
            txtStackSize.Enabled = requiredInputs.Contains("StackSize");
            txtRecipeDuration.Enabled = requiredInputs.Contains("RecipeDuration");
            txtInputDelay.Enabled = requiredInputs.Contains("InputDelay");

            // Update visual styling for disabled fields
            UpdateFieldStyling(txtRPM, txtRPM.Enabled);
            UpdateFieldStyling(txtItemsPerSec, txtItemsPerSec.Enabled);
            UpdateFieldStyling(txtStackSize, txtStackSize.Enabled);
            UpdateFieldStyling(txtRecipeDuration, txtRecipeDuration.Enabled);
            UpdateFieldStyling(txtInputDelay, txtInputDelay.Enabled);
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
            txtRecipeDuration.Clear();
            txtInputDelay.Clear();

            // Reset background colors
            txtRPM.BackColor = System.Drawing.SystemColors.Window;
            txtItemsPerSec.BackColor = System.Drawing.SystemColors.Window;
            txtStackSize.BackColor = System.Drawing.SystemColors.Window;
            txtRecipeDuration.BackColor = System.Drawing.SystemColors.Window;
            txtInputDelay.BackColor = System.Drawing.SystemColors.Window;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
