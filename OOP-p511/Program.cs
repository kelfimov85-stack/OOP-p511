using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    class Rectangle
    {
        private double _width;
        private double _height;

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("Ошибка: ширина должна быть положительным числом!");
                }
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }else
                {
                    Console.WriteLine("Ошибка: высота должна быть положительным числом");
                }
            }
        }

        public double GetArea
        {
            get
            {
                return _width * _height;
            }
            set
            {
                if (0 < value)
                {
                    _width = value;
                    _height = value;
                }else { Console.WriteLine(false); }
            }
        }
        public double GetPerimetr
        {
            get
            {
                return 2 * (_width + _height);
            }
            set
            {
                if (0 < value)
                {
                    _width = value;
                    _height = value;
                }
                else { Console.WriteLine(false); }
            }
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создаеи пряиоугольник");
            Rectangle rectangle1 = new Rectangle(10, 5);

            Console.WriteLine($"Ширина: {rectangle1.Width}");
            Console.WriteLine($"Высота: {rectangle1.Height}");
            Console.WriteLine($"Площадь: {rectangle1.GetArea}");
            Console.WriteLine($"Периметр: {rectangle1.GetPerimetr}");

            rectangle1.Width = -20;
            Console.WriteLine(rectangle1.Width);

            Console.ReadLine();
        }
    }
}
