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
    public class SkillController : Controller
    {
        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            ViewBag.V1 = "Bacariqlar Səhifəsi";
            ViewBag.V2 = "Bacariqlar";
            ViewBag.V3 = "Bacariqlar Səhifəsi";
            var values = skillManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            ViewBag.V1 = "Bacariqlar Yükləmə";
            ViewBag.V2 = "Bacariqlar";
            ViewBag.V3 = "Bacariqlar Yükləmə";
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill Skill)
        {
            skillManager.TAdd(Skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.TGetByID(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            ViewBag.V1 = "Bacariqlar Guncelleme";
            ViewBag.V2 = "Bacariqlar";
            ViewBag.V3 = "Bacariqlar Guncelleme";
            var values = skillManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }

    }
}
