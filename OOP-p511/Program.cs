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
            try
            {
                int[] massiv = { 1, 2, 3, 4, 5, };
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i);
            }catch(IndexOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
            }finally 
            {
                Console.WriteLine("Операция выполлнена");
            }

            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(num1/num2);

            Console.ReadLine();
        }
    }
}
