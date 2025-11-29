using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Name", "01.01.2000", "89220000000", "Moscow", "Russia", "School", "Russia", "Moscow", "511");
            student.Print();

            Point point = new Point(-43, 32, 2);
            point.PrintPoint();

            Console.ReadLine();
        }
    }
}
