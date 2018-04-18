using Microsoft.AspNetCore.Mvc;

namespace PrizmDoc_NET_Core_Sample.Controllers
{
    [Route("/")]
    public class IndexController : Controller
    {
        [HttpGet(""), ActionName("Login")]
        public IActionResult GetLogin()
        {
            return View();
        }
    }
}
