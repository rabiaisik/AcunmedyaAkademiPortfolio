using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class CategoryController : Controller
    {
        DbAcunmedyaakademi1Entities db = new DbAcunmedyaakademi1Entities();

        public ActionResult CategoryList()
        {

            var values = db.Table_category.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(Table_category category)
        {
            db.Table_category.Add(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = db.Table_category.Find(id);
            db.Table_category.Remove(value);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet] 
        public ActionResult UpdateCategory(int id)
        {
            var value = db.Table_category.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Table_category p)
        {
            var value = db.Table_category.Find(p.Categoryıd);
            value.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }

}