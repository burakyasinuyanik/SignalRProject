using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUi.Controllers
{
	public class ProgressBarController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
