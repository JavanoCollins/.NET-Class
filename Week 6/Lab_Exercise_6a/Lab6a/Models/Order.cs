using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab6a.Data;

namespace Lab6a.Models
{
    public class Order
    {
        // Properties
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? OrdersCompleted { get; set; }

        // Foreign key to Customer table (one customer per order)
        public int CustomerId { get; set; }

        // Navigation property
        public Customer Customer { get; set; }
        // Navigation property (intersection table)
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}
