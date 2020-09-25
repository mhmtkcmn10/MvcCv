﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Models.Sinif;


namespace MvcCv.Controllers
{
    public class DeneyimlerController : Controller
    {
        // GET: Deneyimler

        DbMvcCvEntities db = new DbMvcCvEntities();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger2 = db.TBLEXPERIENCE.ToList();
            return View(cs);
        }
        [HttpGet]

        public ActionResult YeniDeneyim()
        {
            return View();
        }

        [HttpPost]

        public ActionResult YeniDeneyim(TBLEXPERIENCE p)
        {
            db.TBLEXPERIENCE.Add(p);
            db.SaveChanges();

            return View();
        }

        public ActionResult DeneyimSil(int id)
        {
            var deneyim = db.TBLEXPERIENCE.Find(id);
            db.TBLEXPERIENCE.Remove(deneyim);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }
        
        public ActionResult VeriGetir(int id)
        {
            var veriler = db.TBLEXPERIENCE.Find(id);
            return View("VeriGetir",veriler);

        }

        public ActionResult Guncelle(TBLEXPERIENCE p)
        {
            var veriler = db.TBLEXPERIENCE.Find(p.ID);

            veriler.TITLE = p.TITLE;
            veriler.SUBTITLE = p.SUBTITLE;
            veriler.DATE = p.DATE;
            veriler.DETAILS = p.DETAILS;

            db.SaveChanges();
            return RedirectToAction("Index");




        }






    }
}