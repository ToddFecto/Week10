using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("product")]
    class Product
    {
        [Key]
        public int productId { get; set; }
        public string productName { get; set; }
        public int supplierId { get; set; }
        public int categoryId { get; set; }
        public string quantityPerUnit { get; set; }
        public decimal unitPrice { get; set; }
        public int unitsInStock { get; set; }
        public int unitsOnOrder { get; set; }
        public int reorderLevel { get; set; }
        public char discontinued { get; set; }
        public override string ToString()
        {
            return $"{productId} {productName} {supplierId} {categoryId} {quantityPerUnit} {unitPrice} {unitsInStock} {unitsOnOrder} {reorderLevel} {discontinued}";
        }
    }
}
