using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Books2021.Models;
using Books2021.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Books2021.Pages
{
    public class BooklistModel : PageModel
    {
        public JsonBookService BookService;

        public IEnumerable<Book> Books { get; private set; }

        public BooklistModel(JsonBookService bookService)
        {
            BookService = bookService;
        }

        public void OnGet()
        {
            Books = BookService.GetBooks();
        }
    }
}
