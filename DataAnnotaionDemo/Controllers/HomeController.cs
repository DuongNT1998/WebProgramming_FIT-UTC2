using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using ValidationMessageDemo.Models;

namespace ValidationMessageDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Student model, string ConfirmPassword,  bool AcceptTerm)
        {

            if(string.IsNullOrEmpty(ConfirmPassword))
            {
                ModelState.AddModelError("ConfirmPassword", "Confirm password is mandatory!");
                ViewData["ConfirmPasswordError"] = "*";
            }

            if (AcceptTerm != true)
            {
                ModelState.AddModelError("AcceptTerm", "You must accept our terms !");
                //ViewData["AcceptTermError"] = "*";
            }
            if (model.Password != ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "Confirm password and Password do not match !");


                return View(model);
            }

            if (ModelState.IsValid == true)
            {

                ViewData["SuccessMessage"] = "<script>alert('Data has been Submitted successfully !')</script>";
            }
            

            return View();
        }
      
    }
}