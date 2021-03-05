using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Entities.Account;
using OnlineShop.ViewModel.AccountViews;
using System.Threading.Tasks;

namespace OnlineShop_ASP_Core.Controllers {
    public class AccountController : Controller {
        readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;

        /// <summary>
        /// Inject our AutoMapper and UserManager class with this constructor
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="userManager">Helps manage the user in the application</param>
        public AccountController(IMapper mapper, UserManager<User> userManager, ApplicationContext context, SignInManager<User> signInManager) {
            _mapper = mapper;
            _userManager = userManager;
            _context = context;
            _signInManager = signInManager;
        }

        [ HttpGet]
        public IActionResult Register() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegistrationViewModel userModel) {
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

            //await _userManager.AddToRoleAsync(user, "Guest");
            /*
             * If everything was successful then sign in the user
             */
            await _signInManager.SignInAsync(user, false);

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = "") {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel userModel) {
            if (ModelState.IsValid) {

                var result = await _signInManager.PasswordSignInAsync(userModel.Email, userModel.Password, userModel.RememberMe, false);

                if (result.Succeeded) {

                    if (!string.IsNullOrEmpty(userModel.ReturnUrl) && Url.IsLocalUrl(userModel.ReturnUrl)) {
                        return Redirect(userModel.ReturnUrl);
                    } else {
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    }
                }
            }

            ModelState.AddModelError("", "Invalid login attempt");
            return View(userModel);



            //this needs to fetch the existing user from the db
            /*using(var context = _context) {
                var result = context.Users.Select(u => u).Where(u => u.Email==userModel.Email).FirstOrDefault();
                if (result==null) {
                    return View(userModel);
                }
                //Session["Email"] = result.Email;
                //Session["Id"] = result.Id;
                return RedirectToAction(nameof(ShopController.Portal), "Shop");
            }*/
        }
    }
}
