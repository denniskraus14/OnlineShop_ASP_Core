using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Repositories.ProductRepo;
using OnlineShop.Entities.Product;
using OnlineShop.ViewModel.ProductViews;
using System.Collections.Generic;

namespace OnlineShop_ASP_Core.Controllers {
    public class ShopController : Controller {
        private IMapper _mapper;
        private IProductRepository _repository;
        private ProductDisplayViewModel _productDisplayViewModel;

        public ShopController(IMapper mapper, IProductRepository repository, ProductDisplayViewModel productDisplayViewModel) {
            _mapper = mapper;
            _repository = repository;
            _productDisplayViewModel = productDisplayViewModel;
        }

        public IActionResult Index() {
            return View();
        }

        [BindProperty(SupportsGet = true)]
        public ProductDisplayViewModel ProductDisplayList { get; set; }

        [HttpGet]
        public IActionResult Portal() {
            /*
             * if(Session["Email"]!=null{
             *      return View();
             * }
             * return RedirectToAction(nameof(AccountController.Login,"Account");
             */

            var products = _repository.Get();    
            var model = _mapper.Map< IEnumerable<Product>, IEnumerable<ProductDisplayViewModel> >(products);

            return View(model); //until session is set up
        }


    }
}
