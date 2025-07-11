using Library_Management_System.Data;
using Library_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(User user)
        {
            var validUser = _context.Users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            if (validUser != null)
            {
                HttpContext.Session.SetString("Username", validUser.Username);
                HttpContext.Session.SetString("Role", validUser.Role);
                return RedirectToAction("Index","Book");
            }
            ViewBag.Message = "Invalid username or password.";
            return View();
        }
        [HttpGet]
        public IActionResult Register() => View();
        [HttpPost]
        public IActionResult Register(User user)
        {
          
            if (!ModelState.IsValid)
            {
                return View(user);

            }
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Success");
            // Save user to database, if using EF
           

        }
        public IActionResult Success()
        {
            return View();
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
