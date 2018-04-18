using Microsoft.AspNetCore.Mvc;

namespace LaunchCodeOAuth.Controllers
{
    [Route("/")]
    public class LoginController : Controller
    {
        [HttpGet("login"), ActionName("Login")]
        public IActionResult GetLogin()
        {
            return View();
        }
    }
}
