using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Constant pi = new Pi(); 
            Expression expression = new Addition(new Number(7f), new Multiplication(new Multiplication(new Number(7), new Addition(new Number(4f), new Number(7f))), pi));

            Expression expression2 = new Addition(new Number(5f), expression);

            Console.WriteLine(expression.Calculate().ToString());
            expression = new Multiplication(new Number(2f), pi);
            Console.WriteLine(expression.Calculate().ToString());

            Variable.Set("r", 5f);

            expression = new Multiplication(pi, new QuadraticPower(Variable.Get("r")));

            Console.WriteLine(string.Format("Pole ko³a dla promienia r = {0} wynosi {1}", Variable.Get("r").Calculate().ToString(), expression.Calculate()));

            Console.ReadKey();
        }
    }
}
