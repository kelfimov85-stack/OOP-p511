using p511_oop;
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
            List<Human> humans = new List<Human>()
            {
                new Builder("Константин", "мужчина", 19),
                new Sailor("Ваня", "мужчина", 37),
                new Pilot("Катерина", "женщина", 28),
                new Sailor("Вика", "женщина", 44)
            };

            foreach(Human human in humans)
            {
                human.Performance();
                human.Work();
            }


            List<Animal> animals = new List<Animal>()
            {
                new Tiger("Кира", "Хищник", 14),
                new Kenguru("Ваня", "Травоядный", 2),
                new Crocodil("Егор", "Хищник", 5)
            };

            foreach(Animal animal in animals)
            {
                animal.Perfomance();
            }

            List<Geometry> fi = new List<Geometry>()
            {
                new Rectangle(2,3),
                new Triangle(4,5.4),
                new Circle(3.14),
                new Trapezoid(4.2,3,3.2)
            };
            foreach (Geometry geom in fi)
            {
                Console.WriteLine(geom.Area());
            }

            Console.ReadLine();
        }
    }
}
