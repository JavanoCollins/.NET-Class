using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Books2021.Models;
using Microsoft.AspNetCore.Hosting;

namespace Books2021.Services
{
    public class JsonBookService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine( WebHostEnvironment.WebRootPath, "data", "books.json"); }
        }

        // Constructor
        public JsonBookService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        // Get books method
        public IEnumerable<Book> GetBooks()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Book[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions { 
                        PropertyNameCaseInsensitive = true 
                    });
            }
        }
    }
}
