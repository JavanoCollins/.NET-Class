using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dinosaurs_Midterm_.Models
{
    public class Dinosaur
    {
        [JsonPropertyName("DinoName")]
        public string Name { get; set; }
        public string Pronounced { get; set; }
        [JsonPropertyName("NameMeans")]
        public string Meaning { get; set; }
        [JsonPropertyName("ClassID")]
        public string Class { get; set; }
        [JsonPropertyName("PeriodID")]
        public string Period { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Dinosaur>(this);
    }
}
