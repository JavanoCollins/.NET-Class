using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCDinos.Models
{
    public class DinoViewModel
    {
        public List<Dinosaur> Dinosaurs { get; set; }
        public SelectList Names { get; set; }
        public string DinoNames { get; set; }
        public string SearchString { get; set; }
    }
}
