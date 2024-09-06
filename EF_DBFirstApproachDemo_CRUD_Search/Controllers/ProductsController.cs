using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF_DBFirstApproachDemo.Controllers
{
    public class ProductsController : Controller
    {
        MyShopEntities1 db = new MyShopEntities1();

        // GET: Products
        public ActionResult Index(string Name, decimal? PriceFrom, decimal? PriceTo, string Storage, int? Category)
        {
            if (Session["username"] != null)
            {
                // Retrieve all products
                var products = db.Products.AsQueryable();

                // Apply filters based on search criteria
                if (!string.IsNullOrEmpty(Name))
                {
                    products = products.Where(p => p.Name.Contains(Name));
                }

                if (PriceFrom.HasValue)
                {
                    products = products.Where(p => p.Price >= PriceFrom.Value);
                }

                if (PriceTo.HasValue)
                {
                    products = products.Where(p => p.Price <= PriceTo.Value);
                }

                if (!string.IsNullOrEmpty(Storage))
                {
                    products = products.Where(p => p.storage == Storage);
                }

                if (Category.HasValue)
                {
                    products = products.Where(p => p.Category_id == Category.Value);
                }

                var data = products.ToList();
                var categories = db.Categories.ToList(); // Assuming you have a Categories DbSet in your context

                ViewBag.Categories = new SelectList(categories, "Id", "Name"); // Change "Id" and "Name" to your actual category ID and name properties
                // Set flag for no products found
                ViewBag.NoProductsFound = !data.Any();

                return View(data);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        // GET: /Products/Create
        public ActionResult Create()
        {
            if (Session["username"] != null)
            {
                var categories = db.Categories.ToList(); // Assuming you have a Categories DbSet in your context
                ViewBag.Categories = new SelectList(categories, "Id", "Name");
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product p)
        {
            if (Session["username"] != null)
            {
                // Check if the model state is valid
                if (ModelState.IsValid)
                {
                    // Handle file upload
                    if (p.ImageFile != null && p.ImageFile.ContentLength > 0)
                    {
                        // Validate file extension
                        var allowedExtensions = new[] { ".jpeg", ".jpg", ".png" };
                        var fileExtension = Path.GetExtension(p.ImageFile.FileName).ToLower();

                        if (!allowedExtensions.Contains(fileExtension))
                        {
                            ModelState.AddModelError("", "Invalid file type. Only .jpeg, .jpg, .png files are allowed.");
                        }
                        else if (p.ImageFile.ContentLength > 1000000) // 1 MB
                        {
                            ModelState.AddModelError("", "File size must be less than or equal to 1 MB.");
                        }
                        else
                        {
                            // Generate a unique file name to avoid overwriting files
                            var fileName = Path.GetFileName(p.ImageFile.FileName);
                            var path = Path.Combine(Server.MapPath("~/Content/images/Products/"), fileName);

                            // Save the file to the server
                            p.ImageFile.SaveAs(path);

                            // Set FilePath to just the file name (for storage in the database)
                            p.FilePath = fileName;
                        }
                    }

                    // Proceed if ModelState is valid
                    if (ModelState.IsValid)
                    {
                        try
                        {
                            db.Products.Add(p); // Add the new product to the database
                            db.SaveChanges(); // Save changes to the database

                            // Set success message
                            TempData["InsertMessage"] = "<script>alert('Data Inserted!');</script>";

                            return RedirectToAction("Index","Products"); // Redirect to the index page or wherever appropriate
                        }
                        catch
                        {
                            // Set failure message
                            TempData["InsertMessage"] = "<script>alert('Data Not Inserted!');</script>";
                        }
                    }
                    else
                    {
                        // Set failure message
                        TempData["InsertMessage"] = "<script>alert('Data Not Inserted!');</script>";
                    }
                }
                else
                {
                    // Set failure message
                    TempData["InsertMessage"] = "<script>alert('Data Not Inserted!');</script>";
                }

                // Reload categories and return the view with errors
                var categories = db.Categories.ToList();
                ViewBag.Categories = new SelectList(categories, "Id", "Name");
                return View(p);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }


        public ActionResult Edit(int id)
        {
            if (Session["username"] != null)
            {
                var categories = db.Categories.ToList(); // Assuming you have a Categories DbSet in your context
                ViewBag.Categories = new SelectList(categories, "Id", "Name");
                var row = db.Products.Where(model => model.id == id).FirstOrDefault();
                return View(row);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product p)
        {
            if (Session["username"] != null)
            {
                if (ModelState.IsValid)
                {
                    // Check if a file is uploaded
                    if (p.ImageFile != null && p.ImageFile.ContentLength > 0)
                    {
                        // Validate file extension
                        var allowedExtensions = new[] { ".jpeg", ".jpg", ".png" };
                        var fileExtension = Path.GetExtension(p.ImageFile.FileName).ToLower();

                        if (!allowedExtensions.Contains(fileExtension))
                        {
                            ModelState.AddModelError("", "Invalid file type. Only .jpeg, .jpg, .png files are allowed.");
                        }
                        else if (p.ImageFile.ContentLength > 1000000) // 1 MB
                        {
                            ModelState.AddModelError("", "File size must be less than or equal to 1 MB.");
                        }
                        else
                        {
                            // Generate a unique file name to avoid overwriting files
                            var fileName = Path.GetFileName(p.ImageFile.FileName);
                            var path = Path.Combine(Server.MapPath("~/Content/images/Products/"), fileName);

                            // Save the file to the server
                            p.ImageFile.SaveAs(path);

                            // Set FilePath to just the file name (for storage in the database)
                            p.FilePath = fileName;
                        }
                    }

                    if (ModelState.IsValid)
                    {
                        try
                        {
                            // Attach the entity to the context and update
                            var existingProduct = db.Products.Find(p.id);
                            if (existingProduct == null)
                            {
                                return HttpNotFound();
                            }

                            // Update the product details
                            existingProduct.Name = p.Name;
                            existingProduct.FilePath = p.FilePath;
                            existingProduct.Price = p.Price;
                            existingProduct.Description = p.Description;
                            existingProduct.storage = p.storage;
                            existingProduct.Category_id = p.Category_id;
                            existingProduct.update_date = DateTime.Now;

                            db.Entry(existingProduct).State = EntityState.Modified;
                            db.SaveChanges();

                            // Set success message
                            TempData["UpdateMessage"] = "<script>alert('Data Updated!');</script>";
                            return RedirectToAction("Index","Products"); // Redirect to the index page or wherever appropriate
                        }
                        catch
                        {
                            // Set failure message
                            TempData["UpdateMessage"] = "<script>alert('Data is not Updated!');</script>";
                        }
                    }
                    else
                    {
                        // Set failure message
                        TempData["UpdateMessage"] = "<script>alert('Data is not Updated!');</script>";
                    }
                }
                else
                {
                    // Set failure message
                    TempData["UpdateMessage"] = "<script>alert('Data is not Updated!');</script>";
                }

                // Reload categories and return the view with errors
                var categories = db.Categories.ToList();
                ViewBag.Categories = new SelectList(categories, "Id", "Name");
                return View(p);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult Delete(int id)
        {

            var ProductIdRow = db.Products.Where(model => model.id == id).FirstOrDefault();
            if (ProductIdRow != null)
            {
                db.Entry(ProductIdRow).State = EntityState.Deleted;
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
            return RedirectToAction("Index","Products");
        }
        public ActionResult Details(int id)
        {
            var DetailsById = db.Products.Where(model => model.id == id).FirstOrDefault();

            return View(DetailsById);
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}