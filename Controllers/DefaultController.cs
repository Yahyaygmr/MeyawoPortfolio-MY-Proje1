using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FeaturePartial()
        {
            var values = db.TblFuture.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutPartial()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult ServicePartial()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PortfolioPartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult TestimonialPartial()
        {
            var values = db.TblTestimonial.Where(x => x.Status == true).ToList();
            return PartialView(values);
        }
        public PartialViewResult FooterPartial()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }
        public PartialViewResult ScriptsPartial()
        {
            return PartialView();
        }
        public PartialViewResult WantToWorkPartial()
        {
            return PartialView();
        }
        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }
        public FileResult DownloadMyCv()
        {
            string filePath = Server.MapPath("/Templates/pdf/ozgecmis.pdf");
            string fileName = "Yahya Yağmur Cv.pdf";
            if (System.IO.File.Exists(filePath))
            {
                return File(filePath, "application/pdf", fileName);
            }
            else
            {
                throw new FileNotFoundException("Belirtilen dosya bulunamadı !");
            }
        }
    }
}