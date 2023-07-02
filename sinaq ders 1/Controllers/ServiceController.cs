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
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
        public IActionResult Index()
        {
            ViewBag.v1 = "Xidmetler Sehifesi";
            ViewBag.v2 = "Xidmetler";
            ViewBag.v3 = "Xidmetler Sehifesi";
            var values = serviceManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetByID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult AddService()
        {
            ViewBag.V1 = "Xidmetler Yukleme";
            ViewBag.V2 = "Deneyimler";
            ViewBag.V3 = "Xidmetler Yukleme";
            return View();
        }
        [HttpPost]

        public IActionResult AddService(Service service)
        {
            serviceManager.TAdd(service);
            return RedirectToAction("Index");
            
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            ViewBag.V1 = "Xidmetler Yukleme";
            ViewBag.V2 = "Deneyimler";
            ViewBag.V3 = "Xidmetler Yukleme";
            var values = serviceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");

        }
    }
}
