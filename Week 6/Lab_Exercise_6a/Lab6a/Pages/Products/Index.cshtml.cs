using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab6a.Data;
using Lab6a.Models;

namespace Lab6a.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Lab6a.Data.BookstoreContext _context;

        public IndexModel(Lab6a.Data.BookstoreContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
