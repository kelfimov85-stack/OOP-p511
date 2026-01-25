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
using System.Net.Http.Json;
using System.Net.Http;

//JSON - JavaScript Object Notation
//API - Application Programming Interface
//HTTP - HyperText Transfer Protocol
//Dto - Data Transfer Object

namespace OOP_p511
{
    public class RegDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        internal class Program
        {
            private static readonly HttpClient _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://localhost:8080")
            };

            static async Task Main(string[] args)
            {
                List <UserDto> users = await _httpClient.GetFromJsonAsync<List<UserDto>>("/api/users");

                if (users is null)
                {
                    Console.WriteLine("Пустой ответ");
                    return;
                }

                foreach (var user in users)
                {
                    Console.WriteLine(user.Username);
                }

                var newUser = new RegDto()
                {
                    Username = "Gas123",
                    Email = "Gas123@gmail.com",
                    Password = "1221"
                };

                HttpResponseMessage responce = await _httpClient.PostAsJsonAsync("/api/auth/register", newUser);

                RegDto created = await responce.Content.ReadFromJsonAsync<RegDto>();
                Console.WriteLine($"{created.Username}");

                Console.ReadLine();
            }
        }
    }
}
