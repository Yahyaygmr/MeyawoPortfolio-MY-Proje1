using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            ViewBag.Categories = GetCategories();
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(TblProject tblProject)
        {
            if (tblProject.Title == null)
            {
                throw new Exception("Formun tamamını doldurun");
            }
            db.TblProject.Add(tblProject);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            ViewBag.Categories = GetCategories();
            var project = db.TblProject.Find(id);
            return View(project);
        }
        [HttpPost]
        public ActionResult UpdateProject(TblProject tblProject)
        {
            var project = db.TblProject.Find(tblProject.ProjectId);

            project.Title = tblProject.Title;
            project.Description = tblProject.Description;
            project.ProjectCategory = tblProject.ProjectCategory;
            project.ProjectUrl = tblProject.ProjectUrl;
            project.ImageUrl = tblProject.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProject(int id)
        {
            var project = db.TblProject.Find(id);
            db.TblProject.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public SelectList GetCategories()
        {
            return new SelectList(db.TblCategory, "CategoryId", "Name");
        }

        //Hocanın kategorileri getirmek için kullandığı select list
        //public List<SelectListItem> GetCategoriesList()
        //{
        //    List<SelectListItem> values = (from x in db.TblCategory.ToList()
        //                               select new SelectListItem
        //                               {
        //                                   Text = x.Name,
        //                                   Value = x.CategoryId.ToString()
        //                               }).ToList();
        //    return values;
        //}
        //Controller tarafınde (List<SelectListItem>)Viewbag.Categories
    }
}