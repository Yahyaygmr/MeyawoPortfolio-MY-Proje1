using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class FutureController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        [HttpGet]
        public ActionResult Index(int id = 1)
        {
            var future = db.TblFuture.Find(id);

            return View("Index",future);
        }
        [HttpPost]
        public ActionResult Index(TblFuture tblFuture)
        {
            var future = db.TblFuture.Find(tblFuture.FutureId);
            future.Header = tblFuture.Header;
            future.NameSurname = tblFuture.NameSurname;
            future.Title = tblFuture.Title;
            db.SaveChanges();

            return View("Index");
        }
    }
}