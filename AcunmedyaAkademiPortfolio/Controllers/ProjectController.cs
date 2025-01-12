using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;


namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class ProjectController : Controller
    {
        DbAcunmedyaakademi1Entities db = new DbAcunmedyaakademi1Entities();
        public ActionResult ProjectList()
        {
            var values = db.Table_project.ToList();
            return View(values);
        }

        [HttpGet]

        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(Table_project project)
        {
            db.Table_project.Add(project);
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }

        public ActionResult DeleteProject(int id)
        {
            var value = db.Table_project.Find(id);
            db.Table_project.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }


        [HttpGet]

        public ActionResult UpdateProject(int id)
        {
            var value = db.Table_project.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult UpdateProject(Table_project p)
        {
            var value = db.Table_project.Find(p.projectld);
            value.projectTitle = p.projectTitle;
            value.Description = p.Description;
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }

    }
}