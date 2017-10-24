using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetcoreapp.DI.Implementation;
using aspnetcoreapp.DI.Interfaces;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace aspnetcoreapp.Controllers
{
    public class HomeController : Controller
    {
        ICustomerRepository _customerRepository;
        public HomeController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //Service locator
            //var repository = HttpContext.RequestServices.GetService(typeof(ICustomerRepository));

            _customerRepository.Add(new Models.Customer() { Id = 1, Name = "Nguyen Van A" });
            _customerRepository.Save();

            var customers = _customerRepository.GetAll();
            return View(customers);
        }
    }
}
