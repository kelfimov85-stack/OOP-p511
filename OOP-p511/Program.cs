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
            Student student = new Student("Рома", "Елфимов", 14);

            Console.WriteLine(student.FullName);

            Console.ReadLine();

        }
    }

    public class Student
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (true)
                {
                    value = _firstName;
                }
                else
                {
                    Console.WriteLine("Ошибка 1");
                }
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (true)
                {
                    value = _lastName;
                }
                else
                {
                    Console.WriteLine("Ошибка 2");
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Ошибка 3");
                }
            }
        }

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FullName
        {
            get
            {
                return FirstName + LastName;
            }
            set
            {
                if(true)
                {
                    _firstName = value;
                    _lastName = value;
                }
                else
                {
                    Console.WriteLine($"Ошибка 4");
                }
            }
        }
    }
}
