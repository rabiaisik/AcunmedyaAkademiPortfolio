using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class TestimonialController : Controller
    {
        DbAcunmedyaakademi1Entities db = new DbAcunmedyaakademi1Entities();
        public ActionResult TestimonialList()
        {
            var values = db.Table_testimoniall.ToList();
            return View(values);
        }

        [HttpGet]

        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(Table_testimoniall testimonial)
        {
            db.Table_testimoniall.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.Table_testimoniall.Find(id);
            db.Table_testimoniall.Remove(value);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }


        [HttpGet]

        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.Table_testimoniall.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult UpdateTestimonial(Table_testimoniall p)
        {
            var value = db.Table_testimoniall.Find(p.TestimoniallId);
            value.NameSurname = p.NameSurname;
            value.CommentDetail = p.CommentDetail;
            value.Job = p.Job;
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}