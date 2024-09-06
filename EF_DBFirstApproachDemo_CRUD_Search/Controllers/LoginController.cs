using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF_DBFirstApproachDemo.Controllers;

namespace EF_DBFirstApproachDemo.Controllers
{
    public class LoginController : Controller
    {
        MyShopEntities1 db=new MyShopEntities1();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(user_shop s)
        {
            if (ModelState.IsValid)
            {
                var credential = db.user_shop.Where(model => model.username==s.username && model.password==s.password).FirstOrDefault();
                if (credential == null)
                {
                    ViewBag.ErrorMessage = "Login Failed! The username or password is incorrect";
                    
                }
                else
                {
                    Session["username"] = s.username;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
        
    }
}