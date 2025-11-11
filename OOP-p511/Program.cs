using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    class Rectangle
    {
        public double width;
        public double height;

        public double GetArea(double width, double height)
        {
            return (width * height);
        }

        public double GetPerimetr (double width, double height)
        {
            return 2 *(width + height); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 3; i++)
            {
                if (i == 1)
                {                  
                    Console.WriteLine($"Прямоугольник {i}:");
                    Rectangle firstRectangle = new Rectangle();

                    Console.Write("- Ширина:");
                    firstRectangle.width = Convert.ToDouble(Console.ReadLine());
                    Console.Write("- Высота:");
                    firstRectangle.height = Convert.ToDouble(Console.ReadLine());

                    double areaFirst = firstRectangle.GetArea(firstRectangle.width, firstRectangle.height);
                    double perimetrFirst = firstRectangle.GetPerimetr(firstRectangle.width, firstRectangle.height);

                    Console.WriteLine($"- Площадь: {areaFirst}");
                    Console.WriteLine($"- Периметр: {perimetrFirst}");
                }
                else
                {
                    Console.WriteLine($"Прямоугольник {i}:");
                    Rectangle secondRectangle = new Rectangle();

                    Console.Write("- Ширина:");
                    secondRectangle.width = Convert.ToDouble(Console.ReadLine());
                    Console.Write("- Высота:");
                    secondRectangle.height = Convert.ToDouble(Console.ReadLine());

                    double areaSecond = secondRectangle.GetArea(secondRectangle.width, secondRectangle.height);
                    double perimetrSecond = secondRectangle.GetPerimetr(secondRectangle.width, secondRectangle.height);

                    Console.WriteLine($"- Площадь: {areaSecond}");
                    Console.WriteLine($"- Периметр: {perimetrSecond}");
                }
            }
        }
    }
}
