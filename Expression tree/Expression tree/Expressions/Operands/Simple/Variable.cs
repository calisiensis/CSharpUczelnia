using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    public class Variable : Number
    {
        private string name = string.Empty;

        private static Dictionary<string, Variable> variablesDictionary = new Dictionary<string, Variable>();

        public Variable(string name, double value) :base (value)
        {
            this.name = name;
        }

        public static void Set(string name, double value)
        {
            Variable variable = null;
            if (variablesDictionary.TryGetValue(name, out variable))
                variable.value = value;
            else
                variablesDictionary.Add(name, new Variable(name, value));
        }
        
        public static Variable Get(string name)
        {
            Variable variable = null;
            if (variablesDictionary.TryGetValue(name, out variable))
                return variable;
            else throw new ArgumentException();
        }

        public override double Calculate()
        {
            return value;
        }
    }
}
