using AcunmedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class PortfolyoController : Controller
    {
        DbAcunmedyaakademi1Entities db = new DbAcunmedyaakademi1Entities();
        public ActionResult PortfolioList()
        {
            var values = db.Table_category.ToList();
            return View(values);
        }


        [HttpGet]

        public ActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePortfolio(Table_category category)
        {
            db.Table_category.Add(category);
            db.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public ActionResult DeletePortfolio(int id)
        {
            var value = db.Table_category.Find(id);
            db.Table_category.Remove(value);
            db.SaveChanges();
            return RedirectToAction("PortfolioList");
        }


        [HttpGet]

        public ActionResult UpdatePortfolio(int id)
        {
            var value = db.Table_category.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult UpdatePortfolio(Table_category p)
        {
            var value = db.Table_category.Find(p.Categoryıd);
            value.Title = p.Title;
            value.ShortDescription = p.ShortDescription;
            value.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}