using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sinaq_ders_1.Controllers
{
    public class AboutController : Controller
    {
        AboutMenager aboutMenager = new AboutMenager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.v1 = "Duzenleme";
            ViewBag.v2 = "Hakkimda";
            ViewBag.v3 = "Hakkimda sehifesi";
            var values = aboutMenager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            aboutMenager.TUpdate(about);
            return RedirectToAction("Index", "Default");
        }
    }
}
