using OnlineShop.Entities.Product;
using System.Collections.Generic;

namespace OnlineShop.Data.Repositories.ProductRepo {
    public interface IProductRepository {
        List<Product> Get();
    }
}
