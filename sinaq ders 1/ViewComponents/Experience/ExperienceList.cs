using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sinaq_ders_1.ViewComponents.Experience
{
    public class ExperienceList : ViewComponent
    {
        ExperienceMenager experienceMenager = new ExperienceMenager(new EfExperienceDal());
        public IViewComponentResult Invoke()
        {
            var values = experienceMenager.TGetList();
            return View(values);
        }
    }
}
