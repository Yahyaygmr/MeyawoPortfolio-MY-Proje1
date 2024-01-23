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
    }
}