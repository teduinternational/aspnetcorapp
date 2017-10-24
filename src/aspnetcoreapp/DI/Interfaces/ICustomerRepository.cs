using aspnetcoreapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetcoreapp.DI.Interfaces
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        List<Customer> GetAll();
        void Save();
    }
}
