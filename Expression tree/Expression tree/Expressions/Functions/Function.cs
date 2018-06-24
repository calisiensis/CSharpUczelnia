using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    public abstract class Function : Expression
    {
        public override bool IsOperand { get { return false; } }

        public override bool IsFunction { get { return true; } }
    }
}
