using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using LibApp.Models;
using LibApp.ViewModels;
using LibApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LibApp.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Random()
        {
            var firstBook = new Book() { Name = "English dictionary" };

            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1" },
                new Customer{Name = "Customer 2" }
            };

            var viewModel = new RandomBookViewModel
            {
                Book = firstBook,
                Customers = customers
            };
            return View(viewModel);
        }

        public IActionResult Index()
        {
            var books = _context.Books
                .Include(b => b.Genre);

            return View(books);

        }

        public IActionResult Details(int id)
        {
            var book = _context.Books
                .Include(b => b.Genre)
                .SingleOrDefault(c => c.Id == id);

            if (book == null)
            {
                return Content("User Not Found ");
            }

            return View(book);
        }

        [Route("/books/released/{year:regex(^\\d{{4}}$)}/{month:range(1,12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public  IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Id = 1, Name = "Hamlet"},
                new Book {Id = 2, Name = "Lalka"}
            };
        }
    }
}
