using System;
using System.Collections.Generic;
using System.Text;

namespace FishingStore.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
