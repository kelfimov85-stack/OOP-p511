using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Net.Http;

//JSON - JavaScript Object Notation
//API - Application Programming Interface

namespace OOP_p511
{
    internal class Program
    {

        static void Main(string[] args)
        {
            const string URL = "https://jsonplaceholder.org/posts";

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(URL);

            var respons = client.GetAsync(URL).Result;

            Console.WriteLine(respons);
            Console.ReadLine();
        }
    }
}
