using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sinaq_ders_1.ViewComponents.Dashboard
{
    public class MessageList :ViewComponent
    {
        UserMessageMenager userMessageMenager = new UserMessageMenager(new EfUserMessageDal());
        public IViewComponentResult Invoke()
        {
            var values = userMessageMenager.GetUserMessageWithUserService();
            return View(values);
        }
    }
}
