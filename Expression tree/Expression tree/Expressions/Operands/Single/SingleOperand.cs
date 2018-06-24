using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    public abstract class SingleOperand : Operand
    {
        protected Expression expression = null;

        public SingleOperand(Expression expression)
        {
            this.expression = expression != null ? expression : throw new NullReferenceException();
        }
    }
}
