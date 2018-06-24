using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    public class QuadraticPower : SingleOperandFunction
    {
        public QuadraticPower(Expression expression) : base(expression) {}

        public override double Calculate()
        {
            return expression.Calculate() * expression.Calculate();
        }
    }
}
