using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    public class Order
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
