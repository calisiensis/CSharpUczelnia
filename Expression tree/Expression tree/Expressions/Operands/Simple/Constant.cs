using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    class Constant : Number
    {
        protected static Dictionary<string, Constant> constantsDictionary = new Dictionary<string, Constant>();
        private string _name = null;

        public Constant(string name, double value) : base (value)
        {
            _name = name;
        }

        public static void Add(string name, double value)
        {
            if (!constantsDictionary.ContainsKey(name))
                constantsDictionary.Add(name, new Constant(name, value));
        }

        public static double Get(string name)
        {
            Constant constant = null;
            if (constantsDictionary.TryGetValue(name, out constant))
                return constant.value;
            else throw new ArgumentException();

        }
    }
}
