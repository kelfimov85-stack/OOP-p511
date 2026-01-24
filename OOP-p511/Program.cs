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
//HTTP - HyperText Transfer Protocol

namespace OOP_p511
{
    class User
    {
        string Id { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string BirthDate { get; set; }
        string Phone { get; set; }
        string WebSite {  get; set; }

    internal class Program
    {

        static async Task Main(string[] args)
        {
            using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://jsonplaceholder.org/posts");

                    User user = client.Get
                }
            Console.ReadLine();
        }
    }
}
