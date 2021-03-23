using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.Extensions.Logging;
using WebApplication1.Services;

namespace WebApplication1.Pages.List
{
    public class ListModel : PageModel
    {
        private readonly ILogger<ListModel> _logger;
        public JsonDinoService DinosaurService;
        public IEnumerable<Dinosaur> Dinosaurs { get; private set; }

        public ListModel(ILogger<ListModel> logger, JsonDinoService dinosaurService)
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
