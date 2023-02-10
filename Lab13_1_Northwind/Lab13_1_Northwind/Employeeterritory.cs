using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("employeeterritory")]
    class Employeeterritory
    {
        [Key]
        public int employeeId { get; set; }
        [Key]
        public string territoryId { get; set; }
        public override string ToString()
        {
            return $"{employeeId} {territoryId}";
        }
    }
}
