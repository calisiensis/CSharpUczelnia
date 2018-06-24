using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    public abstract class SingleOperandFunction : Function
    {
        protected Expression expression = null;

        protected SingleOperandFunction(Expression expression)
        {
            this.expression = expression != null ? expression : throw new NullReferenceException();
        }
    }
}
