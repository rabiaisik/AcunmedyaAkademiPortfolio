using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class AboutController : Controller
    {
        DbAcunmedyaakademi1Entities db = new DbAcunmedyaakademi1Entities();
        public ActionResult AboutList()
        {
            var values = db.TblHakkimda.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult EditAbout(int id)
        {
            var value = db.TblHakkimda.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult EditAbout(TblHakkimda p)
        {
            var value = db.TblHakkimda.Find(p.aboutid);
            value.dogumtarihi = p.dogumtarihi;
            value.kisaaciklama = p.kisaaciklama;
            value.hakkimdaaçiklama = p.hakkimdaaçiklama;
            value.hakkimdabaslik = p.hakkimdabaslik;
            value.egitim = p.egitim;
            value.email = p.email;
            value.sehir = p.sehir;
            value.telefon = p.telefon;
            value.website = p.website;
            value.yas = p.yas;
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}