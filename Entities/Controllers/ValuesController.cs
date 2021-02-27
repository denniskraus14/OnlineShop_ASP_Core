using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShop_ASP_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        private readonly ApplicationContext _context;

        public ValuesController(ApplicationContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() {
            // Add logix with the injected _context object.
        }
    }
}
