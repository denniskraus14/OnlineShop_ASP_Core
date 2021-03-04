using OnlineShop.Entities.Common;

namespace OnlineShop.Entities.Employee {
    public class Employee : BaseEntity {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
    }
}
