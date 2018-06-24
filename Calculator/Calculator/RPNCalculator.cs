using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class RPNCalculator
    {
        private Queue<Symbol> symbolsQueue = null;
        private Stack<Symbol> symbolsStack = null;

        public RPNCalculator(Queue<Symbol> symbols)
        {
            this.symbolsQueue = symbols;
        }

        public Symbol Calculate()
        {
            symbolsStack = new Stack<Symbol>();

            while(symbolsQueue.Count > 0)
            {
                Symbol symbol = symbolsQueue.Dequeue();
                if (symbol is RationalNumber)
                    symbolsStack.Push(symbol);
                else
                {
                    Function function = symbol as Function;
                    Operand operandB = (Operand)symbolsStack.Pop();
                    Operand operandA = (Operand)symbolsStack.Pop();
                    symbolsStack.Push(function.Calculate(operandA, operandB));
                }
            }

            return symbolsStack.Pop();
        }
    }
}
