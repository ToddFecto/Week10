using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace CoffeeShop.Models
{
    public class DAL
    {
        // Database connection
        public static MySqlConnection DB = new MySqlConnection("Server=localhost;Database=coffeehouse;Uid=root;Password=abc123");

        // Read all products
        // Return a list of Products (table name) instances

        public static List<Products> GetAllProducts()
        {
            return DB.GetAll<Products>().ToList();
        }

        // Read the details for a product by id
        public static Products GetProduct(int id)
        {
            return DB.Get<Products>(id);
        }

        // Delete a product by ID
        public static void DeleteProducts(int id)
        {
            Products prod = new Products();
            prod.id = id;
            DB.Delete<Products>(prod);
        }

        // Save a new product (i.e. "insert") ("C" in CRUD for create)
        public static void InsertProduct(Products prod)
        {
            DB.Insert(prod);
        }

        // Update a product
        public static void UpdateProduct(Products prod)
        {
            DB.Update(prod);
        }
    }
}
