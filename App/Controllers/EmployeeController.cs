using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace App.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult MobView()
        {

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer(); // making a object
            
            List<Employee>employees =employeeBusinessLayer.Employees.ToList(); // List<list_name> :> This lines means a data types for list, IEnumerable> Returns a list of specific items || returns a list of 

            return View(employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
           
            return View();
        }
         [HttpPost]
        public ActionResult Create(FormCollection formcollection)
        {
        Employee employee= new employee();
        employee.name=formcollection["Name"];
        employee.gender=formcollection["Gender"];
        employee.city=formcollection["City"];
        employee.dob=formcollection["DateofBirth"];
           
            return View();
        }
        
        
    }
}
