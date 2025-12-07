using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Create_Mod_Calculator_App
{
    public partial class MainForm : Form
    {
        private List<MachineBase> machines = new List<MachineBase>();
        private List<GrindingRecipeDatabase> grindingRecipes;
        private MachineBase selectedMachine;
        private Dictionary<string, (Control, Label)> inputFields;
        private bool isUpdating = false;

        public MainForm()
        {
            InitializeComponent();
            setupWindow();
            inputFields = new Dictionary<string, (Control, Label)>
            {
                { "RPM", (txtRPM, lblRPM) },
                { "ItemsPerSec", (txtItemsPerSec, lblItemsPerSec) },
                { "StackSize", (txtStackSize, lblStackSize) },
                { "RecipeDuration", (cmbRecipeDuration, lblRecipeDuration) },
                { "InputDelay", (txtInputDelay, lblInputDelay) }
            };

            populateMachinesComboBox();
            populateRecipeDurationsComboBox();
            UpdateFieldAvailability();
        }

        /*
         * Gets a list of all the classes that inherit from MachineBase and therefor implement the IMachine interface.
         * This list will then include all concrete classes.
         * This list is used to populate cmbMachines
         */
        private void populateMachinesComboBox()
        {
            var machineTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(MachineBase))).ToList();
            foreach (var machineType in machineTypes)
            {
                var machine = (MachineBase)Activator.CreateInstance(machineType);
                machines.Add(machine);
            }
            cmbMachines.DataSource = machines;
            cmbMachines.DisplayMember = "Name";
            selectedMachine = cmbMachines.SelectedItem as MachineBase;
        }

        private void populateRecipeDurationsComboBox()
        {
            string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "recipe_durations.json");
            string jsonContent = File.ReadAllText(jsonPath);
            var grindingRecipeDatabase = JsonConvert.DeserializeObject<GrindingRecipeDatabase>(jsonContent);
            var grindingRecipes = new List<GrindingRecipeItem>();

            foreach (var kvp in grindingRecipeDatabase.RecipeDurations)
            {
                int duration = int.Parse(kvp.Key);
                foreach (string itemName in kvp.Value.Items)
                {
                    grindingRecipes.Add(new GrindingRecipeItem
                    {
                        Name = itemName,
                        RecipeDuration = duration
                    });
                }
            }

            grindingRecipes = grindingRecipes.OrderBy(item => item.ToString()).ToList();
            grindingRecipes.Add(new GrindingRecipeItem
            {
                Name = "Other",
                RecipeDuration = grindingRecipeDatabase.defaultDuration
            });

            cmbRecipeDuration.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecipeDuration.DataSource = grindingRecipes;
        }

        private void setupWindow()
        {
            this.Text = "Create Mod Calculator";
            this.ClientSize = new Size(500, 550);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
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

                    if (TryGetInputValue(varName, out double val))
                    {
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

        private bool TryGetInputValue(string varName, out double value)
        {
            value = 0;

            // If the inputField chosen is not valid, exit method and return false.
            // If the inputField chosen is valid, lookup in Dictionary and get Item1 (the control being used)
            if (!inputFields.TryGetValue(varName, out var field))
                return false;

            Control control = field.Item1;

            if (control is TextBox txt)
            {
                return double.TryParse(txt.Text, out value);
            }

            if (control is ComboBox cmb)
            {
                if (varName == "RecipeDuration" && cmb.SelectedItem is GrindingRecipeItem item)
                {
                    value = item.RecipeDuration;
                    return true;
                }
            }
            return false;
        }


        private void cmbMachines_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedMachine = cmbMachines.SelectedItem as MachineBase;
            UpdateFieldAvailability();
        }

        private void UpdateFieldAvailability()
        {
            if (selectedMachine == null) return;

            foreach (var kvp in inputFields)
            {
                var (textBox, label) = kvp.Value;

                label.Visible = true;
                textBox.Visible = true;
                textBox.Enabled = true;
            }

            foreach (var kvp in inputFields)
            {
                string input = kvp.Key;
                var (textBox, label) = kvp.Value;

                bool required = selectedMachine.RequiredInputs.Contains(input);

                label.Visible = required;
                textBox.Visible = required;
                textBox.Enabled = required;

                if (!required)
                    textBox.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbRecipeDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRPM_TextChanged(sender, e);
        }
    }
}
