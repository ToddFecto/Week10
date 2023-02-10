using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Linq;

namespace Lab13_1_Northwind
{
    [Table("employee")]
    class Employee
    {
        [Key]
        public int employeeId { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string title { get; set; }
        public string titleOfCourtesy { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime hiredate { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public string extension { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string photo { get; set; }
        public string notes { get; set; }
        public int mgrId { get; set; }
        public string photoPath { get; set; }
        public override string ToString()
        {
            return $"{employeeId} {lastname} {firstname} {title} {titleOfCourtesy} {birthdate} {hiredate} {address} {city} {region} {postalCode} {country} {phone} {extension} {mobile} {email} {photo} {notes} {mgrId} {photoPath}";
        }
    }
}
