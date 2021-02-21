using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dinosaurs_Midterm_.Models;
using Dinosaurs_Midterm_.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Dinosaurs_Midterm_.Pages
{
    public class ListModel : PageModel
    {
        private readonly ILogger<ListModel> _logger;
        public JsonDinosaurService DinosaurService;
        public IEnumerable<Dinosaur> Dinosaurs { get; private set; }

        public ListModel(ILogger<ListModel> logger, JsonDinosaurService dinosaurService)
        {
            _logger = logger;
            DinosaurService = dinosaurService;
        }
        public void OnGet()
        {
            Dinosaurs = DinosaurService.GetDinosaurs();
        }
    }
}
