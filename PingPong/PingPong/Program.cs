using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PingPong
{
    class Program
    {
        private static bool stop = false;
        private static Random los = new Random();


        private static void Ping()
        {
            while (!stop)
            {
                System.Console.Out.WriteLine("PING");
                Thread.Sleep(los.Next(1000));
            }
        }

        private static void Pong()
        {
            while (!stop)
            {
                System.Console.Out.WriteLine("pong");
                Thread.Sleep(los.Next(1000));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("===== start =====");

            Thread p1 = new Thread(Ping);
            Thread p2 = new Thread(Pong);
            p1.Start();
            p2.Start();

            Thread.Sleep(25000);
            stop = true;
            Console.WriteLine("===== stop =====");

        }
    }
}
