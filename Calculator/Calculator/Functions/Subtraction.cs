using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Subtraction : Function
    {
        public Subtraction() {}
        public Subtraction(Operand rationalNumberA, Operand rationalNumberB) : base(rationalNumberA, rationalNumberB) {}

        public override Symbol Calculate()
        {
            if (operandA is RationalNumber && operandB is RationalNumber)
            {
                return (RationalNumber)operandA - (RationalNumber)operandB;
            }

            return null;
        }
    }
}
