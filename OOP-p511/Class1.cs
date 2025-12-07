using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    internal class Student
    {
        protected string Name {  get; set; }
        protected string Surname {  get; set; }
        protected string Group { get; set; }

        public Student(string name, string surname, string group)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }

        public virtual void Print()
        {
            Console.WriteLine("Student");
            Console.WriteLine($"{Name},{Surname},{Group}");
        }
    }
}
