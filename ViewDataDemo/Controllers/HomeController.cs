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
            ViewData["Message"] = "Message from View Data";
            
            ViewData["CurrentTime"] = DateTime.Now.ToString();
            
            string[] Fruits = { "Bananas", "Oranges", "Apples", "Grapes" };
            ViewData["FruitArray"] = Fruits;

            ViewData["SportList"] = new List<string>()
            {
                "Crickets","Hockey","Football","Baseball"
            };

            Employee e= new Employee();
            e.EmpId = 11;
            e.EmpName = "Nguyen Thien Duong";
            e.EmpDept = "Testing Departmet";
            ViewData["Employee"] = e;
            
            return View();
        }
       
    }
}