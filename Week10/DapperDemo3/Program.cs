using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DapperDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=grocerystore;Uid=root;Password=abc123");

            // Read all the products

            Console.WriteLine("All products via GetAll:");
            List<Product> all = db.GetAll<Product>().ToList();  // Requires Dapper.Contrib.Extensions
            foreach (Product prod in all)
            {
                Console.WriteLine(prod);
            }

            // Read one by primary key
            Console.WriteLine("\nOne product by primary key:");
            Product p1 = db.Get<Product>(8);  // Get requires Dapper.Contrib.Extensions
            Console.WriteLine(p1);

            // Read with custom query
            Console.WriteLine("\nRead products with custom query");
            List<Product> fruit = db.Query<Product>("select * from product where category = 'FRUIT'").ToList();
            foreach (Product prod in fruit)
            {
                Console.WriteLine(prod);
            }

            // Read with custom query but ask the user for the category
            Console.WriteLine("\nRead products with custom query: Please enter a category");
            string category = Console.ReadLine();
            fruit = db.Query<Product>($"select * from product where category = '{category}'").ToList();  // Requires Dapper
            foreach (Product prod in fruit)
            {
                Console.WriteLine(prod);
            }
        }
    }
}
