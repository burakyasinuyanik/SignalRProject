using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private readonly IOrderService _orderService;
		private readonly IMapper _mapper;

		public OrderController(IOrderService orderService, IMapper mapper)
		{
			_orderService = orderService;
			_mapper = mapper;
		}

		[HttpGet("TodayOrderPrice")]
		public IActionResult TodayOrderPrice()
		{
			return Ok(_orderService.TTodayOrderPrice());
		}

		[HttpGet("TotalOrderCount")]
		public IActionResult TotalOrderCount()
		{
		  return Ok(_orderService.TTotalOrderCount());
		}
		[HttpGet("ActiveOrderCount")]
		public IActionResult ActiveOrderCount()
		{
			return Ok(_orderService.TActiveOrderCount());
		}
		[HttpGet("LastOrderPrice")]
		public IActionResult LastOrderPrice()
		{
			return Ok(_orderService.TLastOrderPrice());
		}

			
	}
}
