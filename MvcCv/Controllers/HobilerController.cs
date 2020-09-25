using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Models.Sinif;


namespace MvcCv.Controllers
{
    public class HobilerController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: Konferanslar
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger5 = db.TBLINTEREST.ToList();
            return View(cs);
        }
        [HttpGet]

        public ActionResult YeniHobi()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniHobi(TBLINTEREST p)
        {
            db.TBLINTEREST.Add(p);
            db.SaveChanges();
            return View();
        }





    }
}