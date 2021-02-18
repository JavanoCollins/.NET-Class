using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Books2021.Models
{
    public class Book
    {
        public string Author { get; set; }
        public string Country { get; set; }

        [JsonPropertyName("imageLink")]
        public string Image { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }

        public int[] Rankings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Book>(this);
    }
}
