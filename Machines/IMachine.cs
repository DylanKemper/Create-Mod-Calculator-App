using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This interface is used to define the required variables and methods for the subclasses to implement
// This ensures that every subclass adheres to this "definition"
namespace Create_Mod_Calculator_App
{
    public interface IMachine
    {
        string Name { get; }
        string[] RequiredInputs { get; }
        double Solve(string targetVariable, Dictionary<string, double> inputs);
    }
}