using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    internal class User
    {
        private string _name;
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string Name {  
            get 
            {
                return _name; 
            }
            set
            {
                _name = value;
            }
        }

        public User(int age, string name)
        {
            _name = name;
            Age = age;
        }

        public void Print(int age, string name)
        {
            Console.Write($"{name} ");
            Console.Write(age);
        }
    }

    internal class Phone
    {
        private int _price;
        private string _model;
        private string _brand;

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                value = _price;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                value = _model;
            }
        }

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                value = _brand;
            }
        }

        public Phone(int price, string model, string brand) 
        {
            _price = price;
            _model = model;
            _brand = brand;
        }

        public void Print(int price, string brand, string model)
        {
            Console.WriteLine($"{price}, {brand}, {model}");
        }
    }
}
