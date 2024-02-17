using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NatificationController : ControllerBase
	{
		private readonly INatificationService _natificationService;

		public NatificationController(INatificationService natificationService)
		{
			_natificationService = natificationService;
		}

		[HttpGet]
		public IActionResult NatificationList()
		{

			return Ok(_natificationService.TGetListAll());
		}
		[HttpGet("NatificationCountByStatusFalse")]
		public IActionResult NatificationCountByStatusFalse()
		{
			return Ok(_natificationService.TNatificationCountByStatusFalse());
		}
	}
}
