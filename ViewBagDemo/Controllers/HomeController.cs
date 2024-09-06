using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Message from View Data";

            ViewBag.CurrentTime = DateTime.Now.ToString();
            
            string[] Fruits = { "Bananas", "Oranges", "Apples", "Grapes" };
            ViewBag.FruitArray = Fruits;

            ViewBag.SportList = new List<string>()
            {
                "Crickets","Hockey","Football","Baseball"
            };

            Employee e= new Employee();
            e.EmpId = 11;
            e.EmpName = "Nguyen Thien Duong";
            e.EmpDept = "Testing Departmet";
            ViewBag.Employee = e;

            ViewBag.Message1 = "This message is accessed by both ViewBag and ViewData";
            
            return View();
        }
       
    }
}