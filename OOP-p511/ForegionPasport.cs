using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    internal class ForegionPasport : Pasport
    {
        private string InfoVis {  get; set; }
        private int NumberForegionPasport { get; set; }

        public ForegionPasport(string name, string surname, string address, string city, int numberOfPasport, string infoVis, int numberForegionPasport) : base(name, surname, address, city, numberOfPasport)
        {
            InfoVis = infoVis;
            NumberForegionPasport = numberForegionPasport;
        }

        public override void Print()
        {
            base.Print();
            Console.Write($"{InfoVis}, {NumberForegionPasport}");
        }
    }
}
