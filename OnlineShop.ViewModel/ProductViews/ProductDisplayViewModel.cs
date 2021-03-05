using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.ViewModel.ProductViews {
    public class ProductDisplayViewModel {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
    }
}
