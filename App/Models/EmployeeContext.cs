using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

// This namespace will work when Application starts.

namespace App.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }

}
}