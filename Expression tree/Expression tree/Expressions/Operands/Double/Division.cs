using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree.Expressions.Operands.Double
{
    class Division :DoubleOperand
    {
        protected Division(Expression expressionA, Expression expressionB) : base(expressionA, expressionB) {}

        public override double Calculate()
        {
            return expressionA.Calculate() / expressionB.Calculate();
        }

    }
}
