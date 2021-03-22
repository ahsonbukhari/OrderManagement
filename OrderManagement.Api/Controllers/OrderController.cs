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
    public class OrderController : ControllerBase
    {
        private IOrderService _context;

        public OrderController(IOrderService context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetByCustomer(int id)
        {
            return await _context.GetByCustomer(new Customer { Id = id });
        }


        // GET: api/Order/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> Get(int id)
        {
            var orders = await _context.Get(id);

            if (orders == null)
            {
                return NotFound();
            }

            return orders;
        }

        // PUT: api/Order/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order Order)
        {
            throw new NotImplementedException();
        }

        // POST: api/Order
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public void PostOrder(Order Order)
        {
            _context.Add(Order);
        }

        private async Task<bool> OrderExists(int id)
        {
            var order = await _context.Get(id);

            return !(order == null);
        }

    }
}
