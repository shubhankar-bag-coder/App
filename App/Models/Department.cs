﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Models
{
    [Table("Department")]
    public class Department
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

    }
}