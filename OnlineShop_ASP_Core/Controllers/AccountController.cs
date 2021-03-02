using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using OnlineShop_ASP_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop_ASP_Core.Controllers {
    public class AccountController : Controller {
        readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        /// <summary>
        /// Inject our AutoMapper and UserManager class with this constructor
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="userManager">Helps manage the user in the application</param>
        public AccountController(IMapper mapper, UserManager<User> userManager, ApplicationContext context) {
            _mapper = mapper;
            _userManager = userManager;
            _context = context;
        }

        [ HttpGet]
        public IActionResult Register() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel userModel) {
            if (!ModelState.IsValid) {
                return View(userModel);
            }

            var user = _mapper.Map<User>(userModel);

            var result = await _userManager.CreateAsync(user, userModel.Password);

            if (!result.Succeeded) {
                foreach (var error in result.Errors) {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }

                return View(userModel);
            }

            await _userManager.AddToRoleAsync(user, "Guest");

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        public IActionResult Login() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginModel userModel) {
            if (!ModelState.IsValid) {
                return View(userModel);
            }

            //this needs to fetch the existing user from the db
            using(var context = _context) {
                var result = context.Users.Select(u => u).Where(u => u.Email==userModel.Email).FirstOrDefault();
                if (result==null) {
                    return View(userModel);
                }
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
    }
}
