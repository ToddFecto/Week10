using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("custcustdemographics")]
    class Custcustdemographics
    {
        [Key]
        public int custId { get; set; }
        [Key]
        public int customerTypeId { get; set; }
        public override string ToString()
        {
            return $"{custId} {customerTypeId}";
        }
    }
}
