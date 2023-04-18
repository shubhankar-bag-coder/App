using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Models;

namespace App.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index(int departmentId)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List <Employee> employees = employeeContext.Employees.Where(emp=> emp.DepartmentID== departmentId).ToList(); 
            return View(employees);
        }

        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee emps = employeeContext.Employees.Single(emp => emp.EmployeeID == id); // logic
            return View(emps);
        }
    }
}