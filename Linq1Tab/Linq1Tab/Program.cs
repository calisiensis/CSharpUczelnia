using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq1Tab
{
    class Program
    {
        static string[] tab = { 
            "Bolek",
            "Edek",
            "Grzegorz",
            "Zuza",
            "Daniel",
            "Piotr",
            "Marek",
            "Alicja",
            "Monika",
            "Bartek",
            "Zenek",
            "Mirek",
            "Marta",
            "Czesio"
        };
                                 
                                 

        static void Main(string[] args)
        {
            var y =
            from x in Program.tab 
            where x.CompareTo("K") > 0 && x.CompareTo("P") < 0 // zwraca imiona zaczynające się po K i przed P
            orderby x descending
            select x;
            foreach (string z in y)
            Console.WriteLine(" {0} ", z);
            
        }
    }
}
