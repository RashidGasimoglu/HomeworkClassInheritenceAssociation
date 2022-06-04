using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    public class Customer : Person
    {
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int CreditCard { get; set; }
    }
}
