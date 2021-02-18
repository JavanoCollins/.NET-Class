using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public string Type { get; set; }
        public string Diet { get; set; }
        public string Image { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Animal>(this);
    }
}
