using Microsoft.AspNetCore.Mvc;

namespace JwtWebApi.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
