using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab6a.Models
{
    public class ProductOrder
    {
        // Properties
        public int Id { get; set; }
        public int Quantity { get; set; }

        // Foreign key relationships
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        // Navigation properties
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
