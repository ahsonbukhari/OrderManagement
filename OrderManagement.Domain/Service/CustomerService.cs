using OrderManagement.Domain.Model;
using OrderManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Service
{
    public interface ICustomerService
    {
        void Add(Customer customer);
        Task<bool> Update(Customer customer);
        Task<Customer> Get(int id);
        Task<List<Customer>> GetAll();
        bool Delete(Customer customer);
    }

    public class CustomerService : ICustomerService
    {
        private ICustomerRepo _context;
        public CustomerService() // TODO: Replase with -> (ICustomerRepo _context)
        {
            /// TODO: Add dependency injection here...
            /// replace below line with -> _context = context;
            _context = new CustomerRepo();
        }

        public void Add(Customer customer)
        {
            _context.Add(customer);
        }

        public bool Delete(Customer customer)
        {
            return _context.Delete(customer);
        }

        public async Task<Customer> Get(int id)
        {
            return await _context.Get(id);
        }

        public async Task<List<Customer>> GetAll()
        {
            return await _context.GetAll();
        }

        public async Task<bool> Update(Customer customer)
        {
            return await _context.Update(customer);
        }
    }
}
