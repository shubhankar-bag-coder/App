﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Countries =new List<string>()
            {
                "India",
                "UK",
                "USA",
                "Japan"
            };
           return View();
         
 }
        /* public string Index(string id)
        {
            return "Id: "+id + "\n Name:" +Request.QueryString["name"];
        }
        */

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}