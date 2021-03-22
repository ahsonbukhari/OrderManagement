using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Domain.Model;
using OrderManagement.Domain.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _context;

        public CustomerController(ICustomerService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.GetAll();
        }


        // GET: api/customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> Get(int id)
        {
            var customers = await _context.Get(id);

            if (customers == null)
            {
                return NotFound();
            }

            return customers;
        }

        // PUT: api/customer/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (!await CustomerExists(id))
            {
                return NotFound();
            }

            try
            {
                await _context.Update(customer);
            }
            catch (Exception)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/customer
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public void PostCustomer(Customer customer)
        {
            _context.Add(customer);
        }

        private async Task<bool> CustomerExists(int id)
        {
            var customers = await _context.GetAll();

            return customers.Any(e => e.Id == id);
        }
    }
}
