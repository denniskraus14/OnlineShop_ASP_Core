using OnlineShop.Entities.Common;

namespace OnlineShop.Entities.Product {
    public class Product : BaseEntity {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }
}
