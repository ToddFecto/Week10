using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("category")]
    class Category
    {
        [Key]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public string picture { get; set; }
        public override string ToString()
        {
            return $"{categoryId} {categoryName} {description} {picture}";
        }
    }
}
