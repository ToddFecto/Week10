using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("territory")]
    class Territory
    {
        [Key]
        public string territoryId { get; set; }
        public string territorydescription { get; set; }
        public int regionId { get; set; }
        public override string ToString()
        {
            return $"{territoryId} {territorydescription} {regionId}";
        }
    }
}
