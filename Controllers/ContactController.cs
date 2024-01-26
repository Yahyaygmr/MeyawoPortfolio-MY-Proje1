using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
    public class ContactController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        public ActionResult Index()
        {
            var values = db.TblContact.OrderByDescending(x => x.ContactId).ToList();
            return View(values);
        }
        public ActionResult MessageDetail(int id)
        {
            var value = db.TblContact.Find(id);
            return View(value);
        }
        public ActionResult MarkAsRead(int id)
        {
            var message = db.TblContact.Find(id);
            message.IsRead = true;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteMessage(int id)
        {
            var message = db.TblContact.Find(id);
            db.TblContact.Remove(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult CreateContact(TblContact contact)
        {
            if (ModelState.IsValid)
            {
                contact.IsRead = false;
                contact.SendDate = DateTime.Now;
                contact.MessageCategory = 1;
                db.TblContact.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index","Default");
            }
            return View(contact);
        }

    }
}