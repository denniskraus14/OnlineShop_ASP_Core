using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop_ASP_Core.Models {

    public class MyContext : DbContext {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
    }
}
