using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("salesorder")]
    class Salesorder
    {
        [Key]
        public int orderId { get; set; }
        [Key]
        public int custId { get; set; }
        public int employeeId { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime requiredDate { get; set; }
        public DateTime shippedDate { get; set; }
        public int shipperid { get; set; }
        public decimal freight { get; set; }
        public string shipName { get; set; }
        public string shipAddress { get; set; }
        public string shipCity { get; set; }
        public string shipRegion { get; set; }
        public string shipPostalCode { get; set; }
        public string shipCountry { get; set; }
        public override string ToString()
        {
            return $"{orderId} {custId} {employeeId} {orderDate} {requiredDate} {shippedDate} {shipperid} {freight} {shipName} {shipAddress} {shipCity} {shipRegion} {shipPostalCode} {shipCountry}";
        }
    }
}
