using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    class User
    {
        public string name;
        public string surname;
        public int age;
        public string city;

        public User(string name, string surname, int age, string city)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.city = city;
        }

        public void GetInfo()
        {
            Console.WriteLine( $"name: {name}; surname: {surname}; age: {age}; city: {city}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Leha", "Kudaibregenv", 13, "Tyumen");

            user.GetInfo();

            Console.ReadLine();

        }
    }
}
