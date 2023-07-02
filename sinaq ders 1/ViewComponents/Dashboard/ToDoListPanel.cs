using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sinaq_ders_1.ViewComponents.Dashboard
{
    public class ToDoListPanel : ViewComponent
    {
        ToDoListMenager toDoListMenager = new ToDoListMenager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var values = toDoListMenager.TGetList();
            return View(values);
        }
    }
}
