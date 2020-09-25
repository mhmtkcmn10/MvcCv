using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Models.Sinif;


namespace MvcCv.Controllers
{
    public class OdullerController : Controller
    {
        DbMvcCvEntities db = new DbMvcCvEntities();
        // GET: Oduller
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger6 = db.TBLAWARD.ToList();

            return View(cs);
        }

        [HttpGet]
        public ActionResult YeniOdul()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YeniOdul(TBLAWARD p)
        {
            db.TBLAWARD.Add(p);
            db.SaveChanges();
            return View();

        }




        


    }
}