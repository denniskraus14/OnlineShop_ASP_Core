using Microsoft.AspNetCore.Mvc;

namespace OnlineShop_ASP_Core.Controllers {
    public class ShopController : Controller {
        public IActionResult Index() {
            return View();
        }

        [HttpGet]
        public IActionResult Portal() {
            /*
             * if(Session["Email"]!=null{
             *      return View();
             * }
             * return RedirectToAction(nameof(AccountController.Login,"Account");
             */
            return View(); //until session is set up
        }


    }
}
