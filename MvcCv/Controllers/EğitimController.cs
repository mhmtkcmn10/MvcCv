using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Models.Sinif;


namespace MvcCv.Controllers
{
    public class EğitimController : Controller
    {

        DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: Eğitim
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger3 = db.TBLEDUCATION.ToList();
            return View(cs);
        }
        [HttpGet]
        public ActionResult YeniEgitim()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniEgitim(TBLEDUCATION p)
        {
            db.TBLEDUCATION.Add(p);
            db.SaveChanges();
            
            return View();
        }

        public ActionResult EgitimSil(int id)
        {
            var egitim = db.TBLEDUCATION.Find(id);
            db.TBLEDUCATION.Remove(egitim);
            db.SaveChanges();

            return RedirectToAction("Index");


        }



    }
}