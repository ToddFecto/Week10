using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("orderdetail")]
    class Orderdetail
    {
        [Key]
        public int orderDetailId { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }
        public decimal unitPrice { get; set; }
        public int quantity { get; set; }
        public decimal discount { get; set; }
        public override string ToString()
        {
            return $"{orderDetailId} {orderId} {unitPrice} {quantity} {discount}";
        }
    }
}
