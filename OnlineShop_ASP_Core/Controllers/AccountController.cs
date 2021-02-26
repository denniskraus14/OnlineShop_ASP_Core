using Microsoft.AspNetCore.Mvc;
using OnlineShop_ASP_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop_ASP_Core.Controllers {
    public class AccountController : Controller {

        [HttpGet]
        public IActionResult Register() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserRegistrationModel userModel) {
            return View();
        }
    }
}
