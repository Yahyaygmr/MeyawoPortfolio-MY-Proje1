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
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial tblTestimonial)
        {
            if (tblTestimonial.NameSurname == null)
            {
                throw new Exception("Hata");
            }
            db.TblTestimonial.Add(tblTestimonial);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var testimonial = db.TblTestimonial.Find(id);
            return View(testimonial);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial tblTestimonial)
        {
            var testimonial = db.TblTestimonial.Find(tblTestimonial.TestimonialId);

            testimonial.NameSurname = tblTestimonial.NameSurname;
            testimonial.ImageUrl = tblTestimonial.ImageUrl;
            testimonial.Description = tblTestimonial.Description;
            testimonial.Status = tblTestimonial.Status;

            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var testimonial = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(testimonial);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}