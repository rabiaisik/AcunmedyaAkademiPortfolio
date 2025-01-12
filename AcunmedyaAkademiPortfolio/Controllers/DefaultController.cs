using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbAcunmedyaakademi1Entities db = new DbAcunmedyaakademi1Entities();

        public PartialViewResult PartialPortfolio()
        {
            var values = db.Table_category.ToList();
            return PartialView(values);
        }

        public PartialViewResult Partialİletisim()
        {
            var values = db.Tblİletisim.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialStats()
        {
            var values = db.TblStats.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = db.Table_service.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonial()
        {
            var values = db.Table_testimoniall.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialResumeInExperiance()
        {
            var values = db.TblExperience.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialResume()
        {
            var values = db.TblEducation.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
            int totalCategory = db.Table_category.Count();
            int halfcount = totalCategory / 2;
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblHakkimda.ToList();
            return PartialView(values);
        }
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
         public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeroSection()
        {
            return PartialView();
        }
    }

}