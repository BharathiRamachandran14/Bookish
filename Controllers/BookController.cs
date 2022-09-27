using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bookish.Models.Requests;
using Bookish.Models;
using Bookish.Services;

namespace Bookish.Controllers;
[Route("books")]
public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;
    private readonly BookService _bookService;
    private readonly AuthorService _authorService;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
        _bookService = new BookService();
        _authorService = new AuthorService();
    }
    public IActionResult Index()
    {
        List<Book> books = _bookService
            .GetAllBooks()
            .ToList();

        return View(books);
    }

    [HttpPost("")]
    public IActionResult Create([FromForm] BookRequest newBookRequest)
    {
        Book addedBook = _bookService.Create(newBookRequest);

        return RedirectToAction("Index");
    }


    [HttpGet("create")]
    public IActionResult CreateForm()
    {
        List<Author> authors = _authorService
            .GetAllAuthors()
            .ToList();
        List<SelectListItem> selectListAuthors = authors.Select
        (
        a => new SelectListItem { Value = a.Id.ToString(), Text = a.Name }
        )
        .ToList();

        ViewBag.Authors = selectListAuthors;

        return View();
    }

}