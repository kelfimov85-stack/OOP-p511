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

        public void Print1(int price, string brand, string model)
        {
            Console.WriteLine($"{price}, {brand}, {model}");
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
}
