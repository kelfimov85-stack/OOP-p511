using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{

    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(25, "re");
            user.Print(user.Age, user.Name);
            Console.WriteLine();

            Phone phone = new Phone(200, "IPhoone", "10 pro");
            phone.Print(phone.Price, phone.Brand, phone.Model);

            Console.ReadLine();
        }
    }
}
