using p511_oop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List<Document> documents = new List<Document>()
            {
                new TextDocument("Пушкин", "Жили были не тужили"),
                new ImageDocument("Пабло Пикассо", "1920x1080")
            };

            foreach (Document document in documents)
            {
                document.Render();
            }

            Console.ReadLine();
        }
    }
}
