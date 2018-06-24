using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CzynnikiPierwsze
{
    class Program
    {
        static bool CzyPierwsza(int n)
        {
            if (n < 2)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static void NaCzynnikiierwsze(int n)
        {
            int k = 2; 

            while(n > 1)
            {
                while(n % k == 0)
                {
                    Console.Write(string.Format("{0} ", k));
                    n /= k;
                }

                k++;
                while(!CzyPierwsza(k))
                {
                    k++;
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);

            Console.Write(string.Format("{0} = ", n));
            
            n = Math.Abs(n);
            if (CzyPierwsza(n))
            {
                Console.Write(string.Format("{0} 1 ", n)); 
            }
            else
            {
                NaCzynnikiierwsze(n);
            }

            Console.ReadKey();
        }
    }
}
