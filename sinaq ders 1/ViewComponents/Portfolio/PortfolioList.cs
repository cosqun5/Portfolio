using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sinaq_ders_1.ViewComponents.Portfolio
{
    public class PortfolioList : ViewComponent
    {
        PortfolioMenager portfolioMenager = new PortfolioMenager(new EfPortfolioDal());

        public IViewComponentResult Invoke()
        {
            var values = portfolioMenager.TGetList();
            return View(values);
        }
    }
}
