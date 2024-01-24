using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        public ActionResult Index()
        {
            var services = db.TblService.ToList();
            return View(services);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(TblService tblService)
        {
            if (tblService.Title == null)
            {
                throw new Exception("Başlık Alanı Zorunlu !");
            }
            db.TblService.Add(tblService);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var service = db.TblService.Find(id);
            return View(service);
        }
        [HttpPost]
        public ActionResult UpdateService(TblService tblService)
        {
            var service = db.TblService.Find(tblService.ServiceId);

            service.Title = tblService.Title;
            service.Description = tblService.Description;
            service.ImageUrl = tblService.ImageUrl;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult DeleteService(int id)
        {
            var service = db.TblService.Find(id);
            db.TblService.Remove(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}