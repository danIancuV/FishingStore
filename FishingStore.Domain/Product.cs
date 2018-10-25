using System;
using System.Collections.Generic;
using System.Text;

namespace FishingStore.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public ProductType ProductType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Description { get; set; }
        public decimal Price { get ; set ; }
        public List<Order> Orders { get; set; }
    }
}
