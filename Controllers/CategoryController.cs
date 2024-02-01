using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class CategoryController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        public ActionResult Index()
        {
            var categories = db.TblCategory.ToList();
            return View(categories);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(TblCategory category)
        {
            if (category.Name == null)
            {
                throw new Exception("İsim Alanı Zorunludur");
            }
            db.TblCategory.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var category = db.TblCategory.Find(id);
            return View(category);
        }
        [HttpPost]
        public ActionResult UpdateCategory(TblCategory tblCategory)
        {
            var category = db.TblCategory.Find(tblCategory.CategoryId);
            category.Name = tblCategory.Name;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var cetegory = db.TblCategory.Find(id);
            db.TblCategory.Remove(cetegory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}