using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab11b.Models
{
    public class PriceViewModel
    {
        public List<Product> Books { get; set; }
        public SelectList Prices { get; set; }
        public decimal BookPrice { get; set; }
        public string SearchString { get; set; }
    }
}
