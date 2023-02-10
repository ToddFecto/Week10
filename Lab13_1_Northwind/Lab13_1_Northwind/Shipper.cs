using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("shipper")]
    class Shipper
    {
        [Key]
        public int shipperId { get; set; }
        public string companyName { get; set; }
        public string phone { get; set; }
        public override string ToString()
        {
            return $"{shipperId} {companyName} {phone}";
        }
    }
}
