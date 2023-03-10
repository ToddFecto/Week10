using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("customer")]
    class Customer
    {
        [Key]
        public int custId { get; set; }
        public string companyName { get; set; }
        public string contactName { get; set; }
        public string contactTitle { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public override string ToString()
        {
            return $"{custId} {companyName} {contactName} {contactTitle} {address} {city} {region} {postalCode} {country} {phone} {mobile} {email} {fax}";
        }
    }
}
