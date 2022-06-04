using System;
using System.Collections.Generic;
using System.Text;

namespace Trendyol
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
