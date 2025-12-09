using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.RootFinding;

namespace Create_Mod_Calculator_App
{
    public class MechanicalPress : MachineBase
    {
        public override string Name => "MechanicalPress";
        public override string[] RequiredInputs => new[] { "ItemsPerSec", "RPM"};

        public override double Solve(string targetVariable, Dictionary<string, double> inputs)
        {
            // Ensure that all input values are relevant to the current machine and that the required input values are present and valid.
            if (!RequiredInputs.Contains(targetVariable))
                throw new ArgumentException($"'{targetVariable}' is not a valid variable for this machine.");

            // Determine which inputs are needed (all except the target variable)
            var neededInputs = RequiredInputs.Where(v => v != targetVariable);

            // Check that all needed inputs are present
            var missingInputs = neededInputs.Where(v => !inputs.ContainsKey(v)).ToList();
            if (missingInputs.Any())
                throw new ArgumentException($"Missing required inputs: {string.Join(", ", missingInputs)}");

            if (targetVariable == "RPM" && inputs.ContainsKey("ItemsPerSec")) 
                return CalculateRPM(inputs);

            if (targetVariable == "ItemsPerSec" && inputs.ContainsKey("RPM")) 
                return CalculateItemsPerSec(inputs);

            throw new ArgumentException("Invalid target variable.");
        }

        private double CalculateItemsPerSec(Dictionary<string, double> inputs)
        {
            double rpm = inputs["RPM"];
            double clamped = Clamp(rpm / 512.0, 0, 1);
            double lerped = 1 + 59 * clamped;
            return lerped/12;
        }

        private double CalculateRPM(Dictionary<string, double> inputs)
        {
            double itemsPerSec = inputs["ItemsPerSec"];
            Func<double, double> func = (rpm) =>
            {
                double clamped = Clamp(rpm / 512.0, 0, 1);
                double output = (1 + clamped * 59) / 12;
                return output - itemsPerSec;
            };

            return Math.Ceiling(Brent.FindRoot(func, 0, 256, 1e-6));
        }

        protected double Clamp(double value, double min, double max)
        {
            return Math.Max(min, Math.Min(max, value));
        }
    }
}
