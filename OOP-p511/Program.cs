using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Transport> list = new List<Transport>();
            {
                new Car();
                new Bike();
                new Cart();
            };

            double distance = 100;
            int passenger = 2;
            double cargo = 0.4;

            foreach (Transport t in list)
            {
                Console.WriteLine($"Время: {t.CalculateTime(distance)}");
                Console.WriteLine($"Стоимость {t.CalculateCostPerKm(distance, passenger, cargo)}");
            }

            Console.ReadLine();
        }
    }
}
