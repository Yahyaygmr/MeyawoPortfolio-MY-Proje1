using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1 ();
        public ActionResult Index()
        {
            var testimonials = db.TblTestimonial.ToList();
            return View(testimonials);
        }
    }
}