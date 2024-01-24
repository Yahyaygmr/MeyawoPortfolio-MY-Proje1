using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(TblSocialMedia tblSocialMedia)
        {
            if (tblSocialMedia.Title == null)
            {
                throw new Exception("Hata");
            }
            db.TblSocialMedia.Add(tblSocialMedia);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var sc = db.TblSocialMedia.Find(id);
            return View(sc);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia tblSocialMedia)
        {
            var sc = db.TblSocialMedia.Find(tblSocialMedia.SocialMediaId);

            sc.Title = tblSocialMedia.Title;
            sc.Icon = tblSocialMedia.Icon;
            sc.Url = tblSocialMedia.Url;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var sc = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(sc);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}