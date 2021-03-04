using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Entities.Common {
    public abstract class BaseEntity {
        [Key]
        public Guid Id { get; set; }
    }
}
