using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq2kol
{
    class Osoba : IComparable<Osoba>
    {
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public DateTime Urodziny { get; set; }
        public int Wzrost { get; set; }

        public int CompareTo(Osoba os)
        {
            if (Urodziny < os.Urodziny) return -1;
            else if (Urodziny > os.Urodziny) return 1;
            else return 0;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ur. {2}", Imię, Nazwisko, Urodziny.ToString("d.MM.yyyy"));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> lista = new List<Osoba>();
            lista.Add(new Osoba { Imię = "Bartek", Nazwisko = "Rowerowy", Urodziny = new DateTime(1998, 10, 30), Wzrost = 195 });
            lista.Add(new Osoba { Imię = "Heniek", Nazwisko = "Tramwajowy", Urodziny = new DateTime(2004, 01, 25), Wzrost = 160 });
            lista.Add(new Osoba { Imię = "Daniel", Nazwisko = "Skuterowy", Urodziny = new DateTime(2000, 11, 5), Wzrost = 175 });
            lista.Add(new Osoba { Imię = "Franek", Nazwisko = "Autobusowy", Urodziny = new DateTime(2002, 12, 15), Wzrost = 180 });
            lista.Add(new Osoba { Imię = "Grzesiek", Nazwisko = "Kolejowy", Urodziny = new DateTime(1996, 02, 05), Wzrost = 170 });

            var wszystko =
                from p in lista
                orderby p
                select p;
            foreach (var os in wszystko)
                Console.Out.WriteLine(os);

            var ile = (
                from p in lista
                select p).Count<object>();
            Console.Out.WriteLine("liczba wszystkich osob = {0}", ile);
            var sr = (
                from p in lista
                select p.Wzrost).Average();
            Console.Out.WriteLine("sredni wzrost osoby = {0}", sr);
            
            var najstarszy = (
                from p in lista
                select p.Urodziny).Min();
            Console.Out.WriteLine("najstarsza osoba = {0}", najstarszy);

            var najmlodszy = (
                from p in lista
                select p.Urodziny).Max();
            Console.Out.WriteLine("najmlodsza osoba = {0}", najmlodszy);

            DateTime w21 = new DateTime(2001, 1, 1);
            var najstarsze = 
                from p in lista
                where p.Urodziny.CompareTo(w21) < 0
                select new { Im = p.Imię, Naz = p.Nazwisko };
            Console.WriteLine("Osoby urodzone po 01.01.2001:");
            foreach (var os in najstarsze)
                Console.Out.WriteLine("{0} {1}", os.Im, os.Naz);
            
        }
    }
}