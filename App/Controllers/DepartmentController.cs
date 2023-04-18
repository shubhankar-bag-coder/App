using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.Models;

namespace App.Controllers
{
    public class DepartmentController : Controller
    {
        public ActionResult Index()
        {
            EmployeeContext employeeContext = new EmployeeContext();
            List<Department> department = employeeContext.Departments.ToList();

            return View(department);
        }
    }
}