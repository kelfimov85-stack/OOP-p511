using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    internal class Student
    {
        private string _fullName { get; set; }
        private string _dateBorn { get; set; }
        private string _numberPhone { get; set; }
        private string _city { get; set; }
        private string _country { get; set; }
        private string _school { get; set; }
        private string _countryOfSchool { get; set; }
        private string _cityOfschool { get; set; }
        private string _numberOfGroup { get; set; }

        public Student(string fullName, string dateBorn, string phone, string city, string country, string school, string countryOfSchool, string cityOfschool, string numberOfGroup)
        {
            _fullName = fullName;
            _dateBorn = dateBorn;
            _numberPhone = phone;
            _city = city;
            _country = country;
            _school = school;
            _countryOfSchool = countryOfSchool;
            _cityOfschool = cityOfschool;
            _numberOfGroup = numberOfGroup;
        }

        public void Print()
        {
            Console.WriteLine($"{_fullName}, {_dateBorn}, {_numberPhone}, {_city}, {_country}, {_school}, {_countryOfSchool}, {_cityOfschool}, {_numberOfGroup}");
        }
    }

    internal class Point
    {
        private int _x { get; set; }
        private int _y { get; set; }
        private int _z { get; set; }

        public Point(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"{_x},{_y}, {_z} ");
        }
    }


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
