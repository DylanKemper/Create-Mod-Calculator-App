using MathNet.Numerics.RootFinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Create_Mod_Calculator_App
{
    internal class CrushingWheel : MachineBase
    {
        public override string Name => "crushing_wheel";

        public override string[] RequiredInputs => new[] { "ItemsPerSec", "RPM", "StackSize", "RecipeDuration", "InputDelay"};

        public override double Solve(string targetVariable, Dictionary<string, double> inputs)
        {
            if (targetVariable == "ItemsPerSec")
                return CalculateItemsPerSec(inputs);
            if (targetVariable == "RPM")
                return CalculateRPM(inputs);
            throw new ArgumentException("Invalid target variable.");
        }

        private double CalculateItemsPerSec(Dictionary<string, double> inputs)
        {
            // Read user-provided inputs
            double rpm = inputs["RPM"];
            double stackSize = inputs["StackSize"];
            double recipeDuration = inputs["RecipeDuration"];
            double inputDelay = inputs["InputDelay"];

            // Compute clamp
            double clampedValue = Clamp((0.08 * rpm) / Math.Log(stackSize, 2), 0.25, 20);

            // Calculate ticks per stack
            double ticksPerStack = Math.Floor((recipeDuration - 20) / clampedValue) + 1 + inputDelay;

            // Convert to items/sec
            double itemsPerSec = (20 * stackSize) / ticksPerStack;

            return itemsPerSec;
        }

        public static double Clamp(double value, double min, double max)
        {
            return Math.Max(min, Math.Min(value, max));
        }

        private double CalculateRPM(Dictionary<string, double> inputs)
        {
            double itemsPerSec = inputs["ItemsPerSec"];
            double stackSize = inputs["StackSize"];
            double recipeDuration = inputs["RecipeDuration"];
            double inputDelay = inputs["InputDelay"];

            Func<double, double> func = (rpm) =>
            {
                double clamped = Math.Max(0.25, Math.Min((0.08 * rpm) / (Math.Log(stackSize) / Math.Log(2)), 20));
                double ticksPerStack = Math.Floor((recipeDuration - 20) / clamped) + 1 + inputDelay;
                double outputItemsPerSec = (20 * stackSize) / ticksPerStack;
                return outputItemsPerSec - itemsPerSec;
            };

            return Math.Ceiling(Brent.FindRoot(func, 0, 256, 1e-6));
        }
    }
}
