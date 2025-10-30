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
        public override string Name => "mechanical_press";
        public override string[] RequiredInputs => new[] { "ItemsPerSec", "RPM"};

        public override double Solve(string targetVariable, Dictionary<string, double> inputs)
        {
            if (targetVariable == "RPM")
            {
                double itemsPerSec = inputs["ItemsPerSec"];

                Func<double, double> func = (rpm) =>
                {
                    double clamped = Clamp(rpm / 512.0, 0, 1);
                    double output = (1 + clamped * 59) / 12;
                    return output - itemsPerSec;
                };

                return Math.Ceiling(Brent.FindRoot(func, 0, 256, 1e-6));  // Your Brent method
            }

            if (targetVariable == "ItemsPerSec")
            {
                double rpm = inputs["RPM"];
                double clamped = Clamp(rpm / 512.0, 0, 1);
                return (1 + clamped * 59) / 12;
            }

            throw new ArgumentException("Invalid target variable.");
        }

        protected double Clamp(double value, double min, double max)
        {
            return Math.Max(min, Math.Min(max, value));
        }
    }
}
