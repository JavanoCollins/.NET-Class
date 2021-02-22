using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab_7a.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Create a new pet object
            Models.Cat myCat = new Models.Cat()
            {
                Name = "White Legs",
                Type = "Savannah",
                DOB = new DateTime(2017, 07, 04)
            };

            return View(myCat);
        }
    }
}
