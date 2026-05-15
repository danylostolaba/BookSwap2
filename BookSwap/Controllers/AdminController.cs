using Microsoft.AspNetCore.Mvc;

namespace BookSwap.Controllers
{
    public class AdminController : Controller
    {
        private const string AdminPassword = "bookswap123";

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string password)
        {
            if (password == AdminPassword)
            {
                HttpContext.Session.SetString("IsAdmin", "true");

                return RedirectToAction("Index", "Books");
            }

            ViewBag.Error = "Wrong password";

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("IsAdmin");

            return RedirectToAction("Index", "Books");
        }
    }
}