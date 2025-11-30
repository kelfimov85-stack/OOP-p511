using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    internal class Book
    {
        public string Author {  get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string author, string name, string publisher, int year, int pages)
        {
            Author = author;
            Name = name;
            Publisher = publisher;
            Year = year;
            Pages = pages;
        }

        public void Print()
        {
            Console.WriteLine($"{Author}, {Name}, {Publisher},{Year}, {Pages}");
        }
    }
}
