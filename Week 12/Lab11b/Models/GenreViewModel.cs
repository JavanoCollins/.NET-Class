using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab11b.Models
{
    public class GenreViewModel
    {
        // List of Books
        public List<Product> Books { get; set; }

        // Select (to allow user to select from the list)
        public SelectList Genres { get; set; }

        // Property to contain the selected price
        public string BookGenre { get; set; }

        // Property to contain the search string
        public string SearchString { get; set; }
    }
}
