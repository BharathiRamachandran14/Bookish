using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Services;

namespace Bookish.Controllers;
[Route("books")]
public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;
    private readonly BookService _bookService;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
        _bookService = new BookService();
    }
    public IActionResult Index()
    {
        var context = new BookishContext();
        List<Book> books = _bookService
            .GetAllBooks()
            .ToList();

        return View(books);
    }

    [HttpPost("")]
    public IActionResult Create([FromForm] Book newBook)
    {
        Book addedBook = _bookService.Create(newBook);

        return RedirectToAction("Index");
    }


    [HttpGet("create")]
    public IActionResult CreateForm()
    {
        return View();
    }

}