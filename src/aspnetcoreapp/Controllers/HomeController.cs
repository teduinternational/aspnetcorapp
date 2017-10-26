using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetcoreapp.DI.Implementation;
using aspnetcoreapp.DI.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using aspnetcoreapp.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace aspnetcoreapp.Controllers
{
    public class HomeController : Controller
    {
        ICustomerRepository _customerRepository;
        IConfiguration _config;
        private readonly IOptions<MyOptions> _myOptions;
        public HomeController(ICustomerRepository customerRepository, IConfiguration config, IOptions<MyOptions> options)
        {
            _customerRepository = customerRepository;
            _config = config;
            _myOptions = options;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //Service locator
            //var repository = HttpContext.RequestServices.GetService(typeof(ICustomerRepository));

            //_customerRepository.Add(new Models.Customer() { Id = 1, Name = "Nguyen Van A" });
            //_customerRepository.Save();

            var homeTitle = _config["HomeTitle"];
            var homeKeyword = _config.GetValue<string>("HomeKeyword");
            var pageSize = _config.GetValue<int>("PageSize");

            var options = _config.GetSection("Options");
            var option1 = options.GetValue<string>("Option1");

            var myOptions = _myOptions.Value;

            var customers = _customerRepository.GetAll();
            return View(customers);
        }
    }
}
