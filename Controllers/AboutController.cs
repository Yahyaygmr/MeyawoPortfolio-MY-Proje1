using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class AboutController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        [HttpGet]
        public ActionResult Index(int id = 1)
        {
            var about = db.TblAbout.Find(id);
            return View("Index", about);
        }
        [HttpPost]
        public ActionResult Index(TblAbout tblAbout)
        {
            var about = db.TblAbout.Find(tblAbout.AboutId);
            about.Title = tblAbout.Title;
            about.Description = tblAbout.Description;
            about.Header = tblAbout.Header;
            about.ImageUrl = tblAbout.ImageUrl;
            db.SaveChanges();
            return View();
        }
    }
}