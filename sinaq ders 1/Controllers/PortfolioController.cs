using BusinessLayer.Concrate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sinaq_ders_1.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioMenager portfolioMenager = new PortfolioMenager(new EfPortfolioDal());
        public IActionResult Index()
        {
            ViewBag.V1 = "Portfolio Səhifəsi";
            ViewBag.V2 = "Portfolio";
            ViewBag.V3 = "Portfolio Səhifəsi";
            var values = portfolioMenager.TGetList();
            return View(values);
        }

        [HttpGet]

        public IActionResult AddPortfolio()
        { 
            ViewBag.V1 = "Portfolio Səhifəsi";
            ViewBag.V2 = "Portfolio";
            ViewBag.V3 = "Portfolio Ekleme";
            return View();
        }

        [HttpPost]
           public IActionResult AddPortfolio(Portfolio p)
        {
           
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(p);
            if (result.IsValid)
            { 
                portfolioMenager.TAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
         }  
        public IActionResult PortfolioDelete(int id)
            {
                var values = portfolioMenager.TGetByID(id);
                portfolioMenager.TDelete(values);
                return RedirectToAction("Index");

            }

        [HttpGet]
        public IActionResult PortfolioUpdate(int id)
        {
            ViewBag.V1 = "Portfolio Səhifəsi";
            ViewBag.V2 = "Portfolio";
            ViewBag.V3 = "Portfolio Guncelleme";
            var values = portfolioMenager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult PortfolioUpdate(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);
            if (result.IsValid)
            {
                portfolioMenager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

            
        }
    }
}
