using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee s=new Employee();
          s.EmpId = 11;
      s.EmpName = "Nguyen Thien Duong";
      s.EmpDept = 32;
      ViewBag.Employee = s;    
    return View();
            
            return View();
        }



    }
}
