using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCv.Models.Entity;
using System.Web.Mvc;
using MvcCv.Models.Sinif;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        DbMvcCvEntities db = new DbMvcCvEntities();
        
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.TBLABOUT.ToList();
            cs.Deger2 = db.TBLEXPERIENCE.ToList();
            cs.Deger3 = db.TBLEDUCATION.ToList();
            cs.Deger4 = db.TBLSKILL.ToList();
            cs.Deger5 = db.TBLINTEREST.ToList();
            cs.Deger6 = db.TBLAWARD.ToList();

            return View(cs);

            //var degerler = db.TBLABOUT.ToList();
            //return View(degerler);
        }
    }
}