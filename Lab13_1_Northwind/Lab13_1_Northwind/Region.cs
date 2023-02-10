using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("region")]
    class Region
    {
        [Key]
        public int regionId { get; set; }
        public string regiondescription { get; set; }
        public override string ToString()
        {
            return $"{regionId} {regiondescription}";
        }
    }
}
