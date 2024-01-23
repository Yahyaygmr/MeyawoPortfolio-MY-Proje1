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
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1 ();
        public ActionResult Index()
        {
            var values = db.TblSocialMedia.ToList ();
            return View(values);
        }
    }
}