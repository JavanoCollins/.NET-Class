using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2.Models;
using Assignment2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment2.Pages
{
    public class AnimalsModel : PageModel
    {
        public JsonAnimalService AnimalService;
        public IEnumerable<Animal> Animals { get; private set; }

        public AnimalsModel(JsonAnimalService animalService)
        {
            AnimalService = animalService;
        }
        public void OnGet()
        {
            Animals = AnimalService.GetAnimals();
        }
    }
}
