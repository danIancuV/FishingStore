using System;
using System.Collections.Generic;
using System.Security.Principal;

namespace FishingStore.Domain
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<Order> Orders { get; set; }
    }
}
