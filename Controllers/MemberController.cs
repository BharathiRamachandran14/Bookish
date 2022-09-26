using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Controllers;
[Route("members")]
public class MemberController : Controller
{
    private readonly ILogger<MemberController> _logger;

    public MemberController(ILogger<MemberController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        // var context = new BookishContext();
        // List<Book> books = context.Books
        //     .Include(b => b.Author)
        //     .ToList();

        // return View(books);
        List<Member>members = new List<Member> 
        {
            new Member 
            {
                MemberName = "Oli",
                CheckedOutBooks = new List<string>{
                "Harry Potter 1",
                "Harry Potter 2"
                }
            }

        };
        return View(members);    
    }

    // [HttpPost("")]
    // public IActionResult Create([FromForm] Book newBook)
    // {
    //     var context = new BookishContext();
    //     var addedEntity = context.Books.Add(newBook);

    //     context.SaveChanges();

    //     // Book addedBook = addedEntity.Entity;

    //     return RedirectToAction("Index");
    // }


    // [HttpGet("create")]
    // public IActionResult CreateForm()
    // {
    //     return View();
    // }

}