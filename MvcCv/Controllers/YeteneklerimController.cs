using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Models.Sinif;


namespace MvcCv.Controllers
{
    public class YeteneklerimController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();

        // GET: Yeteneklerim
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger4 = db.TBLSKILL.ToList();

            return View(cs);
        }
        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]

        public ActionResult YeniYetenek(TBLSKILL p)
        {
            db.TBLSKILL.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult YetenekSil(int id)
        {
            var yetenek = db.TBLSKILL.Find(id);
            db.TBLSKILL.Remove(yetenek);
            db.SaveChanges();

            return RedirectToAction("Index");

        }



    }
}