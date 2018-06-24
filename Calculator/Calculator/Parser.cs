using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Parser
    {
        private string _input = string.Empty;

        public Parser(string input)
        {
            _input = input;
        }

        public Queue<Symbol> Parse()
        {
            string [] symbols = _input.Split(' ');
            Queue<Symbol> symbolList = new Queue<Symbol>();

            foreach (var symbol in symbols)
            {
                symbolList.Enqueue(SymbolFactory.Factor(symbol));
            }

            return symbolList;
        }
    }
}
