using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Models
{
    [Table("Employee")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public int DepartmentID { get; set; } 

     }
}