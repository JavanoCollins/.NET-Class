using System.Collections.Generic;
using Lab6a.Models;

namespace Lab6a.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Navigation Property
        public ICollection<Order> Orders { get; set; }
    }
}