using Microsoft.AspNetCore.Mvc;
using Library_Management_System.Models;
using Library_Management_System.Data;
namespace Library_Management_System.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Books.ToList());

        public IActionResult Details(int id)
        {
            var book = _context.Books.Find(id);
            return book == null ? NotFound() : View(book);
        }

        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Role") != "Admin") return Unauthorized();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (HttpContext.Session.GetString("Role") != "Admin") return Unauthorized();
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.GetString("Role") != "Admin") return Unauthorized();
            var book = _context.Books.Find(id);
            return book == null ? NotFound() : View(book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (HttpContext.Session.GetString("Role") != "Admin") return Unauthorized();
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetString("Role") != "Admin") return Unauthorized();
            var book = _context.Books.Find(id);
            return book == null ? NotFound() : View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            if (HttpContext.Session.GetString("Role") != "Admin") return Unauthorized();
            var book = _context.Books.Find(id);
            _context.Books.Remove(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

