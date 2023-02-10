using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=northwind;Uid=root;Password=abc123");

            //    // Read all the product

            //    Console.WriteLine("All products via GetAll:");
            //    List<Product> all = db.GetAll<Product>().ToList();  // Requires Dapper.Contrib.Extensions
            //    foreach (Product prod in all)
            //    {
            //        Console.WriteLine(prod);
            //    }

            //    // Read one by primary key
            //    Console.WriteLine("\nOne product by primary key:");
            //    Product p1 = db.Get<Product>(8);  // Get requires Dapper.Contrib.Extensions
            //    Console.WriteLine(p1);

            //    // Read with custom query
            //    Console.WriteLine("\nRead products with custom query");
            //    List<Product> cat = db.Query<Product>("select * from product where categoryId = '2'").ToList();
            //    foreach (Product prod in cat)
            //    {
            //        Console.WriteLine(prod);
            //    }

            //    // Read with custom query but ask the user for the category
            //    Console.WriteLine("\nRead products with custom query: Please enter a category");
            //    string catId = Console.ReadLine();
            //    cat = db.Query<Product>($"select * from product where categoryId = '{catId}'").ToList();  // Requires Dapper
            //    foreach (Product prod in cat)
            //    {
            //        Console.WriteLine(prod);
            //    }

            //// Read with custom query
            //Console.WriteLine("\nRead products with custom query");
            //List<Customer> cust = db.Query<Customer>("select * from customer").ToList();
            //foreach (Customer cst in cust)
            //{
            //    Console.WriteLine(cst);
            //}

            //// Read with custom query
            //Console.WriteLine("\nRead products with custom query");
            //List<Customer> cust = db.Query<Customer>("select distinct(country) from customer").ToList();
            //foreach (Customer cst in cust)
            //{
            //    Console.WriteLine(cst);
            //}

            //// Read with custom query
            //Console.WriteLine("\nRead products with custom query");
            //List<Customer> cust = db.Query<Customer>("select * from customer where companyName like 'Customer CC%'").ToList();
            //foreach (Customer cst in cust)
            //{
            //    Console.WriteLine(cst);
            //}

            //// Read with custom query
            //Console.WriteLine("\nRead products with custom query");
            //List<Orderdetail> ordr = db.Query<Orderdetail>("select * from orderdetail where orderDetailId < 101").ToList();
            //foreach (Orderdetail ord in ordr)
            //{
            //    Console.WriteLine(ord);
            //}

            // Read with custom query
            Console.WriteLine("\nRead products with custom query");
            List<Customer> cust = db.Query<Customer>("select * from customer where postalCode = '1010' or postalCode = '3012' or postalCode = '12209' or postalCode = '05023'").ToList();
            foreach (Customer cst in cust)
            {
                Console.WriteLine(cst);
            }
        }
    }
}
