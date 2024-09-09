using Microsoft.AspNetCore.Mvc;

namespace WFS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.IsLogin = true;
            return View();
        }
    }
}
