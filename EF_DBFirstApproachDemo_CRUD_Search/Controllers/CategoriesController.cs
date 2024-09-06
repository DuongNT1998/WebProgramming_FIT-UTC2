using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_DBFirstApproachDemo.Controllers
{
    public class CategoriesController : Controller
    {
        MyShopEntities1 db = new MyShopEntities1();

        public ActionResult Index()
        {
            if (Session["username"] != null)
            {
                var data = db.Categories.ToList();
                return View(data);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Category c)
        {

            c.create_date = DateTime.Now;
            c.update_date = c.create_date;
            if (ModelState.IsValid)
            {
                db.Categories.Add(c);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    ViewBag.InsertMessage = "<script>alert('Data Inserted!');window.location.href='/Categories/Index';</script>";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data Not Inserted!');window.location.href='/Categories/Index';</script>";

                }
            }

            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = db.Categories.Where(model => model.id == id).FirstOrDefault();
            return View(row);

        }
        [HttpPost]
        public ActionResult Edit(Category c)
        {
            // Retrieve the existing category from the database to get the original create_date
            var existingCategory = db.Categories.Find(c.id);

            if (existingCategory != null)
            {
                // Set the update_date to the current system datetime
                existingCategory.update_date = DateTime.Now;
                existingCategory.Name = c.Name;

                if (ModelState.IsValid)
                {
                    db.Entry(existingCategory).State = EntityState.Modified;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        ViewBag.UpdateMessage = "<script>alert('Data Updated!');window.location.href='/Categories/Index';</script>";
                        ModelState.Clear();

                    }
                    else
                    {
                        ViewBag.UpdateMessage = "<script>alert('Data Not Updated!');window.location.href='/Categories/Index';</script>";
                    }
                }
            }
            else
            {
                ViewBag.UpdateMessage = "<script>alert('Category not found!')</script>";
            }

            return View(existingCategory);
        }
        public ActionResult Delete(int id)
        {

            var CategoryIdRow = db.Categories.Where(model => model.id == id).FirstOrDefault();
            if (CategoryIdRow != null)
            {
                db.Entry(CategoryIdRow).State = EntityState.Deleted;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["DeleteMessage"] = "Data deleted !";
                }
                else
                {
                    TempData["DeleteMessage"] = "Data is not deleted !";

                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var DetailsById = db.Categories.Where(model => model.id == id).FirstOrDefault();

            return View(DetailsById);
        }
       
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}