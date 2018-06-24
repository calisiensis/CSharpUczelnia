using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    public abstract class Operand : Expression
    {
        public override bool IsOperand { get { return true; } }

        public override bool IsFunction { get { return false; } }
    }
}
