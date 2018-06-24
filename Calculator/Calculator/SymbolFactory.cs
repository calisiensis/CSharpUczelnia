using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SymbolFactory
    {
        private const string Function_Symbols = "+-/*";

        public static Symbol Factor(string input)
        {
            if(IsFunction(input))
            {
                switch(input)
                {
                    case "-":
                        return new Subtraction();
                    case "+":
                        return new Addition();
                    case "*":
                        return new Multiplication();
                    case "/":
                        return new Division();

                }
            }
            else
            {
                return new RationalNumber(input);
            }

            return null;
        }

        private static bool IsFunction(string input)
        {
            return Function_Symbols.Contains(input);
        }
    }
}
