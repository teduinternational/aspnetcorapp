using aspnetcoreapp.DI.Interfaces;
using aspnetcoreapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreapp.DI.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {
        ApplicationDbContext _context;
        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Customer customer)
        {
            _context.Add(customer);
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
