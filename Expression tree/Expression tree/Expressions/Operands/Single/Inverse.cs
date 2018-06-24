using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree.Expressions.Operands.Single
{
    class Inverse : SingleOperand
    {
        protected Inverse(Expression expression) : base(expression) {}

        public override double Calculate()
        {
            return 1 / expression.Calculate();
        }
    }
}
