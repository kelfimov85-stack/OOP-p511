using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OOP_p511
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Book[] books = new Book[]
{
                new Book("Лев Толстой", "Война и мир", "Русский вестник", 1869, 1225),
                new Book("Фёдор Достоевский", "Преступление и наказание", "Русский вестник", 1866, 672),
                new Book("Михаил Булгаков", "Мастер и Маргарита", "Москва", 1967, 480),
                new Book("Александр Пушкин", "Евгений Онегин", "Азбука", 1833, 384),
                new Book("Николай Гоголь", "Мёртвые души", "Советский писатель", 1842, 352)
           };

            string author = Console.ReadLine();

            foreach (Book book in books)
            {
                if (book.Author.ToLower() == author.ToLower())
                {
                    book.Print();
                }
            }

           string publisher = Console.ReadLine();
            foreach (Book book in books)
            {
                if (book.Publisher.ToLower() == publisher.ToLower())
                {
                    book.Print();
                }
            }

            int year = Convert.ToInt32(Console.ReadLine());
            foreach (Book book in books)
            {
                if (book.Year == year)
                {
                    book.Print();
                }
            }

            Console.ReadLine();
        }
    }
}
