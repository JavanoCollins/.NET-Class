using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assignment5.Models
{
    public class CompanyViewModel
    {
        public List<Game> Games { get; set; }

        public SelectList Companys { get; set; }

        public string GameCompany { get; set; }

        public string SearchString { get; set; }
    }
}
