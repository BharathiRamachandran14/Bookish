using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Controllers;
[Route("books")]
public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        var context = new BookishContext();
        List<Book> books = context.Books
            .Include(b => b.Author)
            .ToList();

        return View(books);
    }

    [HttpPost("")]
    public IActionResult Create([FromForm] Book newBook)
    {
        var context = new BookishContext();
        var addedEntity = context.Books.Add(newBook);

        context.SaveChanges();

        Book addedBook = addedEntity.Entity;

        return Created($"/books/{addedBook.Id}", addedBook);
    }


    [HttpGet("create")]
    public IActionResult CreateForm()
    {
        return View();
    }

}
