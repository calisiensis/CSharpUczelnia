using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public abstract class Function : Symbol
    {
        protected Operand operandA = null;
        protected Operand operandB = null;

        public Function() {}

        public Function(Operand operandA, Operand operandB)
        {
            this.operandA = operandA;
            this.operandB = operandB;
        }

        public Symbol Calculate(Operand operandA, Operand operandB)
        {
            this.operandA = operandA;
            this.operandB = operandB;

            return Calculate();
        }
    }
}
