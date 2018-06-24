using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    class Pi : Constant
    {
        public Pi() : base("Pi", Math.PI)
        {
            if(!constantsDictionary.ContainsKey("Pi"))
                constantsDictionary.Add("Pi", this);
        }
    }
}
