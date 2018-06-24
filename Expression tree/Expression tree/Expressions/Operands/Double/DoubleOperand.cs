using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    public abstract class DoubleOperand : Operand
    {
        protected Expression expressionA = null;
        protected Expression expressionB = null;

        public DoubleOperand(Expression expressionA, Expression expressionB)
        {
            if (expressionA == null || expressionB == null) throw new NullReferenceException();

            this.expressionA = expressionA;
            this.expressionB = expressionB;
        }
    }
}
