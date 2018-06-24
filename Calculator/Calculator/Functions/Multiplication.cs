using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Multiplication : Function
    {
        public Multiplication()
        {
        }

        public Multiplication(Operand operandA, Operand operandB) : base(operandA, operandB)
        {
        }

        public override Symbol Calculate()
        {
            return (RationalNumber)operandA * (RationalNumber)operandB;
        }
    }
}
