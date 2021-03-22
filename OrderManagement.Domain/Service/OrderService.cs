using OrderManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Service
{
    public interface IOrderService
    {
        void Add(Order order);
        Task<Order> Get(int id);
        Task<bool> Delete(int id);
        Task<List<Order>> GetByCustomer(Customer customer);
    }

    public class OrderService : IOrderService
    {
        public void Add(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetByCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
