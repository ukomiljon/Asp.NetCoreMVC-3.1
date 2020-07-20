using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebGentle_BookStore.Controllers
{
    public class BookController : Controller
    {
        public string GetAllBooks()
        {
            return "All books";
        }

        public string GetBook(int id)
        {
            return $"book id={id}";
        }

        public string SearchBook(string name, string author)
        {
            return $"found book {name} by author {author}";
        }
    }
}
