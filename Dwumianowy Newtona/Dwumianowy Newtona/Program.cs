using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dwumianowy_Newtona
{

    public class TrojkatPascala
    {
        private ulong _n = 0;
        private ulong[][] _trojkat = null;

        public ulong[] Newton
        {
            get
            {
                return _trojkat[_trojkat.Length - 1];
            }
        }

        public TrojkatPascala(ulong n)
        {
            _n = n;
            _trojkat = new ulong[_n][];
            _trojkat[0] = new ulong[] { 1 };
        }

        static ulong[] GenerujNastepna(ulong[] poprzednia)
        {
            ulong[] nastepna = new ulong[poprzednia.Length + 1];

            nastepna[0] = nastepna[nastepna.Length - 1] = 1;

            for (ulong i = 1; i < (ulong)nastepna.Length - 1; i++)
            {
                nastepna[i] = poprzednia[i - 1] + poprzednia[i];
            }

            return nastepna;
        }

        public void GenerujTrojkat()
        {
            ulong[] obecna = _trojkat[0];

            for (ulong i = 1; i <= _n - 1; i++)
            {
                _trojkat[i] = GenerujNastepna(_trojkat[i - 1]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string symbolA = args[0];
            string symbolB = args[1];
            ulong liczba = ulong.Parse(args[2]);

            TrojkatPascala trojkatPascala = new TrojkatPascala(liczba);
            trojkatPascala.GenerujTrojkat();

            ulong[] newton = trojkatPascala.Newton;

            Console.Write("({0}+{1})^{2} = ", symbolA, symbolB, liczba);
            for (int i = 0; i < newton.Length; i++)
            {
                Console.Write("{0}{1}{2}{3}{4}{5}{6}",
                    newton[i] == 1 ? "" : string.Format("{0}*", newton[i]),
                    liczba - (ulong)i == 0 ? "" : symbolA,
                    liczba - (ulong)i == 0 ? "" : string.Format("^{0}", liczba - (ulong)i),
                    newton[i] > 1 && i > 0 ? "*" : "",
                    i == 0 ? "" : string.Format("{0}", symbolB),
                    i <= 1 ? "" : string.Format("^{0}", i),
                    i < newton.Length - 1 ? " + " : "");
            }

            Console.ReadKey();
        }
    }
}
