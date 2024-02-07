using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MenuTableController : ControllerBase
	{
		private readonly IMenuTableService _menuTableService;
		private readonly IMapper _mapper;

		public MenuTableController(IMenuTableService menuTableService, IMapper mapper)
		{
			_menuTableService = menuTableService;
			_mapper = mapper;
		}

		[HttpGet("MenuTableCount")]
		public ActionResult MenuTableCount()
		{
			return Ok(_menuTableService.MenuTableCount());
		}
	}
}
