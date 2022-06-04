using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    public class Payment
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public string PaymentMethod { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
