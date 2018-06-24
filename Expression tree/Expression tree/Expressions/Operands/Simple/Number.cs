using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    public class Number : Operand
    {
        protected double value = 0;

        public Number(double value)
        {
            this.value = value;
        }

        public override double Calculate()
        {
            return value;
        }
    }
}
