using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5b_Entity.Models
{
    public class Customer
    {
#nullable enable
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Added properties
        public string? HomeAddress { get; set; }
        public string? EmailAddress { get; set; }
#nullable disable

        // Navigation Property
        public ICollection<Order> Orders { get; set; }
    }
}
