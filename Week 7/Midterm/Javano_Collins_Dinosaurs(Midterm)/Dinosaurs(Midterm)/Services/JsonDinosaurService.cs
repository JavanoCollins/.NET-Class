using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Dinosaurs_Midterm_.Models;
using Microsoft.AspNetCore.Hosting;

namespace Dinosaurs_Midterm_.Services
{
    public class JsonDinosaurService
    {
        // Constructor
        public JsonDinosaurService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "dinosaurs.json"); }
        }

        // Get Dinosaurs method
        public IEnumerable<Dinosaur> GetDinosaurs()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Dinosaur[]>(jsonFileReader.ReadToEnd(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }
    }
}
