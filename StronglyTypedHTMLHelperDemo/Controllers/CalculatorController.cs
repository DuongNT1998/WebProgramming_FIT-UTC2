using StronglyTypedViewDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedViewDemo.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculate
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Index(Calculator c)
        {
          
            int num1 = c.num1;
            int num2 = c.num2;
            int result = num1 + num2;
            ViewBag.result = result;
            return View();
        }
    }
}