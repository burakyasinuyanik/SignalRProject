using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUi.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
