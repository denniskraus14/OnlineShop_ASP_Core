using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineShop.Data;
using OnlineShop.Entities.Employee;
using OnlineShop.ViewModel.Employee;
using OnlineShop.ViewModel.Error;
using System.Diagnostics;
using System.Threading.Tasks;

namespace OnlineShop_ASP_Core.Controllers {
    public class HomeController : Controller {        
        private readonly ApplicationContext _context;
        private readonly ILogger<HomeController> _logger;
        private IMapper _mapper;

        public HomeController(ApplicationContext context, ILogger<HomeController> logger, IMapper mapper) {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [BindProperty(SupportsGet = true)]
        public EmployeeDisplayViewModel EmployeeDisplayList { get; set; }

        /// <summary>
        /// List of employees
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public async Task<IActionResult> Employees(EmployeeDisplayViewModel employeeDisplayViewModel) {
            var employeesDb = await _context.Employees.ToListAsync();
            var employees = _mapper.Map<Employee>(employeeDisplayViewModel);

            EmployeeDisplayList = await _context.Employees.ToListAsync();



            return View(employees);
        }
            
    }
}
