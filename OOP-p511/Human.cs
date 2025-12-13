using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    abstract class Human
    {
        protected string name;
        protected string sex;
        protected int age;

        public Human(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        public abstract void Performance();
        public abstract void Work();
    }

    class Builder : Human
    {
        public Builder(string name, string sex, int age) : base(name, sex, age) { }

        public override void Performance()
        {
            Console.WriteLine("----------");
            Console.Write("[ПРЕДСТАВЛЕНИЕ]");
            Console.WriteLine($"Зовут меня {name}, я {sex} {age} лет, а работаю я строителем");
        }
        public override void Work()
        {
            Console.Write("[РАБОТА]");
            Console.WriteLine("С помощью своих инструментов строю дома");
            Console.WriteLine("----------");
        }
    }

    class Sailor : Human
    {
        public Sailor(string name, string sex, int age) : base(name, sex, age) { }

        public override void Performance()
        {
            Console.WriteLine("----------");
            Console.Write("[ПРЕДСТАВЛЕНИЕ]");
            Console.WriteLine($"Зовут меня {name}, я {sex} {age} лет, а работаю я моряком");
        }
        public override void Work()
        {
            Console.Write("[РАБОТА]");
            Console.WriteLine("На большом корабле я плавую в морях и океанах, перевозя грузы из одного места в другое");
            Console.WriteLine("----------");
        }
    }

    class Pilot : Human
    {
        public Pilot(string name, string sex, int age) : base(name, sex, age) { }

        public override void Performance()
        {
            Console.WriteLine("----------");
            Console.Write("[ПРЕДСТАВЛЕНИЕ]");
            Console.WriteLine($"Зовут меня {name}, я {sex} {age} лет, а работаю пилотом");
        }
        public override void Work()
        {
            Console.Write("[РАБОТА]");
            Console.WriteLine("Летаю высоко в небе на самолете и возжу туда сюда грузы и людей");
            Console.WriteLine("----------");
        }
    }
}
