using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    internal class Pasport
    {
        protected string Name {  get; set; }
        protected string Surname { get; set; }
        protected string Address { get; set; }
        protected string City { get; set; }
        protected int NumberOfPasport { get; set; }

        public Pasport(string name, string surname, string address, string city, int numberOfPasport)
        {
            Name = name;
            Surname = surname;
            Address = address;
            City = city;
            NumberOfPasport = numberOfPasport;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{Name}, {Surname}, {Address}, {City}, {NumberOfPasport}");
        }
    }
}
