using Microsoft.AspNetCore.Mvc;

namespace LaunchCodeOAuth.Controllers
{
    [Route("/")]
    public class IndexController : Controller
    {
        [HttpGet(""), ActionName("Index")]
        public IActionResult GetIndex()
        {
            return View();
        }
    }
}
