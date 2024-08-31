using Microsoft.AspNetCore.Mvc;

namespace demo_mvc.Controllers
{
    public class AccountController1 : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
