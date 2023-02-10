using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;
using Dapper;

namespace CoffeeShop.Models
{
    [Table("products")]
    public class Products
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
        //public override string ToString()
        //{
        //    return $"{id} {name} {description} {price} {category}";
        //}
    }
}
