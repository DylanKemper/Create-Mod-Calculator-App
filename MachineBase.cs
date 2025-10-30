using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Mod_Calculator_App
{
    public abstract class MachineBase : IMachine
    {
        public abstract string Name { get; }
        public abstract string[] RequiredInputs { get; }
        public abstract double Solve(string targetVariable, Dictionary<string, double> inputs);
    }
}