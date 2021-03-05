using OnlineShop.Entities.Product;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Data.Repositories.ProductRepo {
    public class ProductRepository : IProductRepository {
        private ApplicationContext Context { get; set; }

        public ProductRepository(ApplicationContext context) { Context = context; }

        public List<Product> Get() {
            return Context.Products.ToList();
            /*string name = "Product One";
            return Context.Products.Select(p => p.Name == p.Name);*/
        }
    }
}
