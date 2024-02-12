using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUi.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
