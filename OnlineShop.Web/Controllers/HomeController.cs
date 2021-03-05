using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Data;
using OnlineShop.Data.Repositories.EmployeeRepo;
using OnlineShop.Entities.Employee;
using OnlineShop.ViewModel.EmployeeViews;
using OnlineShop.ViewModel.ErrorViews;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace OnlineShop_ASP_Core.Controllers {
    public class HomeController : Controller {        
        private readonly ApplicationContext _context;
        private readonly ILogger<HomeController> _logger;
        private IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly EmployeeDisplayViewModel _employeeDisplayViewModel;

        public HomeController(ApplicationContext context, ILogger<HomeController> logger, IMapper mapper, IEmployeeRepository employeeRepository, EmployeeDisplayViewModel employeeDisplayViewModel) {
            _context = context;
            _logger = logger;
            _mapper = mapper;
            _employeeRepository = employeeRepository;
            _employeeDisplayViewModel = employeeDisplayViewModel;
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
        //[Authorize]
        /*public IActionResult Employees() {*/
        public IActionResult Employees() {

            // Try #1
            //var employeesDb = await _context.Employees.ToListAsync();
            //var employees = _mapper.Map<Employee>(employeeDisplayViewModel);

            // Try #2
            //List<Employee> employee = new List<Employee>();
            //var employeesList = _mapper.Map< List<Employee>, List<EmployeeDisplayViewModel> >(employee);
            //_mapper.ConfigurationProvider.AssertConfigurationIsValid();

            // Try #3
            //EmployeeDisplayList = await _context.Employees.ToListAsync();
            //_employeeDisplayViewModel.HandleRequest();

            //return View(employees);

            // Try #4
            //List<Employee> employee = new List<Employee>();
            //List<EmployeeDisplayViewModel> employeeVM = new List<EmployeeDisplayViewModel>();
            //employeeVM = employee.Select(Mapper.Map<Employee, EmployeeDisplayViewModel>);

            // Try #5
            //IQueryable<Employee> employee = new List<Employee>().AsQueryable();
            //IQueryable<EmployeeDisplayViewModel> employeeVM = employee.ProjectTo<EmployeeDisplayViewModel>(employee, e => e.Id, employee);

            // Try #6
            //var employees = _mapper.Map< IEnumerable<EmployeeDisplayViewModel> >(employeeDisplayViewModel);

            // Try #7
            var employees = _employeeRepository.Get();
            var model = _mapper.Map< IEnumerable<Employee>, IEnumerable<EmployeeDisplayViewModel> >(employees);

            return View(model);
        }

    }
}
