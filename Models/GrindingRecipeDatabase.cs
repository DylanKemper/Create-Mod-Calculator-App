using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Mod_Calculator_App
{

    public class GrindingRecipeDatabase
    {
        public Dictionary<string, DurationGroup> RecipeDurations { get; set; }
        public int defaultDuration { get; set; }
    }

    public class DurationGroup
    {
        public List<string> Items { get; set; }
    }

    public class GrindingRecipeItem
    {
        public string Name { get; set; }
        public int RecipeDuration { get; set; }

        public override string ToString() => FormatItemName(Name);

        private string FormatItemName(string camelCase)
        {
            if (string.IsNullOrEmpty(camelCase))
                return camelCase;
            var result = System.Text.RegularExpressions.Regex.Replace(
                camelCase,
                "(?<!^)([A-Z])",
                " $1"
            );
            return char.ToUpper(result[0]) + result.Substring(1);
        }
    }
}
