using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    internal class Aspirant : Student
    {
        private int Work { get; set; }

        public Aspirant(string name, string surname, string  group, int work) : base(name, surname, group)
        {
            Work = work;
        }

        public override void Print()
        {
            base.Print();
            Console.Write(Work);
        }
    }
}
