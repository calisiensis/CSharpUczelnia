using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    public class Sinus : SingleOperand
    {
        public Sinus(Expression expression) : base(expression) {}

        public override double Calculate()
        {
            return Math.Sin(expression.Calculate());
        }
    }
}
