using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pierwiastkowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Error.Write("a = ");
            String s = Console.In.ReadLine();
            double a = Convert.ToDouble(s);
            Console.Error.Write("b = ");
            double b = Convert.ToDouble(Console.In.ReadLine());
            double c = Math.Sqrt(a * a + b * b); //math.sqrt - metoda statyczna liczaca pierwiastek z sum kwadratow a i b
            Console.Out.WriteLine("{0:F3}", c);
            //Console.Out.WriteLine("{0:F3}", Math.Sqrt(a * a + b * b)); - rozwiazanie drugie
            Console.ReadKey();
        }
    }
}
