using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using sinaq_ders_1.Areas.Writer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sinaq_ders_1.Areas.Writer.Controllers
{
    [Area("Writer")]

    public class RegisterController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegistrViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegistrViewModel p)
        {
            WriterUser w = new WriterUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.UserName,
                ImageUrl = p.ImageUrl
            };

            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(w, p.Password);

                if (result.Succeeded )
                {
                    return RedirectToAction("Index", "Default");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}



//    public class RegisterController : Controller
//    {


//        private readonly UserManager<WriterUser> _userManager;

//        public RegisterController(UserManager<WriterUser> userManager)
//        {
//            _userManager = userManager;
//        }

//        [HttpGet]
//        public IActionResult Index()
//        {

//            return View(new UserRegistrViewModel());
//        }
//        [HttpPost]
//        public async Task<IActionResult> Index(UserRegistrViewModel p)
//        {
//            //if (ModelState.IsValid)
//            //{


//                WriterUser w = new WriterUser()
//                {
//                    Name = p.Name,
//                    Surname = p.Surname,
//                    ImageUrl = p.ImageUrl,
//                    Email = p.Mail,
//                    UserName = p.UserName
//                };
//                var result = await _userManager.CreateAsync(w, p.Password);
//                if (result.Succeeded)
//                {
//                    return RedirectToAction("Index", "Login");
//                }
//                else
//                {
//                    foreach (var item in result.Errors)
//                    {
//                        ModelState.AddModelError("", item.Description);
//                    }
//                }
//            //}
//            return View(p);
//        }
//    }
//}
