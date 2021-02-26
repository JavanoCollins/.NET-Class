using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab_7b.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Models.Coin MainCoin = new Models.Coin()
            {
                ScoreOne = 0,
                ScoreTwo = 0
            };
            //return View();
            return View(MainCoin);
        }
    }
}
