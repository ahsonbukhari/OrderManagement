using OrderManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Repository
{
    public interface IOrderRepo
    {
        void Add(Order order);
        Task<Order> Get(int id);
        Task<List<Order>> GetByCustomer(Customer customer);
        Task<bool> DeleteOrder(int id);
    }

    class OrderRepo : IOrderRepo
    {
        public void Add(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteOrder(int id)
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
