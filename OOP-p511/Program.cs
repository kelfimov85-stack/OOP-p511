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
    internal class Invetory
    {
        private List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }
        public void Found(int id)
        {
            Console.WriteLine(_products[id]);
        }
    }

    internal class Product
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private double Price { get; set; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Invetory invetory = new Invetory();

            Console.Write("Добавлен продукт: 1 ");
            Product product1 = new Product(1, Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
            invetory.Add(product1);
            Console.WriteLine("Добавлен продукт: 2 ");
            Product product2 = new Product(2, Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
            invetory.Add(product2);
            Console.WriteLine("Добавлен продукт: 3 ");
            Product product3 = new Product(3, Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
            invetory.Add(product3);

            Console.Write("Индекс продукта, который вам нужно зайти: ");
            int id = Convert.ToInt32(Console.ReadLine());

            invetory.Found(id);

            Console.ReadLine();
        }
    }
}
