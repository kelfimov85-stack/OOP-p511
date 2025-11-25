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
            Student student = new Student(-12, "1212", "21212");

            Console.WriteLine(student.FullName);
            Console.ReadLine();
        }
    }

    internal class Student
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
                value = _firstName;
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
                value = _lastName;
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
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Ошибка 3");
                }
            }
        }

        public Student(int age, string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
        }

        public string FullName
        {
            get
            {
                return _firstName + " " + _lastName;
            }
            set
            {
                _firstName = value;
                _lastName = value;
            }
        }
    }
}
