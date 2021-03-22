using Dapper;
using OrderManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace OrderManagement.Domain.Repository
{
    public interface ICustomerRepo
    {
        void Add(Customer customer);
        Task<bool> Update(Customer customer);
        Task<Customer> Get(int id);
        Task<List<Customer>> GetAll();
        bool Delete(Customer customer);
    }

    class CustomerRepo : ICustomerRepo
    {
        private IDbConnection _context;
        public CustomerRepo()
        {
            _context = new SqlConnection("Data Source=.;Initial Catalog=FileUploadTest;Integrated Security=True;");
        }

        public void Add(Customer customer)
        {
            try
            {
                string sql = @"[dbo].[stp_Customer_Insert]";

                var p = new DynamicParameters();
                p.Add("@Name", customer.FirstName);
                p.Add("@Location", customer.LastName);
                p.Add("@FileSize", customer.Email);

                _context.Query(sql, p,
                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                // TODO: Add error logging here...
                throw;
            }
        }

        public bool Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
