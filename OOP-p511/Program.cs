using p511_oop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_p511
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const string FILE_PATH = "C:\\Users\\user\\Desktop";
            StudentManager studentManager = new StudentManager();

            studentManager.AddStudent(new Student("GOYDA", 23, 4.3));

            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1/num2);

            Console.ReadLine();
        }
    }
}
