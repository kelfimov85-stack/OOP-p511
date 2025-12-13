using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    abstract class Animal
    {
        protected string name;
        protected string typeFood;
        protected int age;

        public Animal(string name, string typeFood, int age)
        {
            this.name = name;
            this.typeFood = typeFood;
            this.age = age;
        }

        public abstract void Perfomance();
    }

    class Tiger : Animal
    {
        public Tiger(string name, string typeFood, int age) : base(name, typeFood, age) { }

        public override void Perfomance()
        {
            Console.WriteLine();
            Console.WriteLine($"Вид \t Имя \t  Вид питания \t Возраст");
            Console.WriteLine($"Тигр \t {name}  \t  {typeFood} \t {age}");
            Console.WriteLine();
        }
    }

    class Crocodil : Animal
    {
        public Crocodil(string name, string typeFood, int age) : base(name, typeFood, age) { }

        public override void Perfomance()
        {
            Console.WriteLine();
            Console.WriteLine($"Вид \t Имя \t  Вид питания \t Возраст");
            Console.WriteLine($"Крокодил {name}  \t  {typeFood} \t {age}");
            Console.WriteLine();
        }
    }

    class Kenguru : Animal
    {
        public Kenguru(string name, string typeFood, int age) : base(name, typeFood, age) { }

        public override void Perfomance()
        {
            Console.WriteLine();
            Console.WriteLine($"Вид \t Имя \t  Вид питания \t Возраст");
            Console.WriteLine($"Кенгуру\t {name}  \t  {typeFood}  \t {age}");
            Console.WriteLine();
        }
    }
}
