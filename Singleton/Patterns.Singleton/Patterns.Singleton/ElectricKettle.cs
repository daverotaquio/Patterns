using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Patterns.Singleton
{
    public class ElectricKettle
    {
        private static readonly ElectricKettle Instance = new ElectricKettle();

        public static ElectricKettle GetElectricKettle()
        {
            Console.WriteLine("Starting");
            return Instance;
        }

        public void Fill()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Filling...");
        }

        public void Drain()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Draining...");
        }

        public void Boil()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Boiling...");
        }
    }
}
