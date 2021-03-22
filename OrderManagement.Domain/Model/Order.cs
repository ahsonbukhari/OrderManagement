using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Domain.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<Product> Products { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal Discount { get; set; }
    }
}
