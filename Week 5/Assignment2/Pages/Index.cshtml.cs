using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2.Models;
using Assignment2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Assignment2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonAnimalService AnimalService;
        public IEnumerable<Animal> Animals { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, JsonAnimalService animalService)
        {
            _logger = logger;
            AnimalService = animalService;
        }

        public void OnGet()
        {
            Animals = AnimalService.GetAnimals();
        }
    }
}
