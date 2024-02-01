using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        public ActionResult Index()
        {
            //Aggregate functions --> Sum Avg Count Min Max

            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.messageCount = db.TblContact.Count();
            ViewBag.flutterProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.isReadCount = db.TblContact.Where(x => x.IsRead == false).Count();
            //ViewBag.lastProject = db.TblProject.OrderByDescending(x => x.ProjectId).First();
            ViewBag.lastProject = db.LastProjectName().FirstOrDefault();

            ViewBag.serviceCount = db.TblService.Count();
            ViewBag.socialMedias = db.TblSocialMedia.Count();
            ViewBag.testimonials = db.TblTestimonial.Count();
            ViewBag.csharpProcectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();

                return View();
        }
    }
}