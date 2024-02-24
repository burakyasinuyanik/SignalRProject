using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NotificationController : ControllerBase
	{
		private readonly INotificationService _notificationService;

		public NotificationController(INotificationService notificationService)
		{
			_notificationService = notificationService;
		}

		[HttpGet]
		public IActionResult NotificationList()
		{

			return Ok(_notificationService.TGetListAll());
		}
		[HttpGet("NotificationCountByStatusFalse")]
		public IActionResult NotificationCountByStatusFalse()
		{
			return Ok(_notificationService.TNatificationCountByStatusFalse());
		}
		
		[HttpGet("GetAllNotifationByFalse")]
		public IActionResult GetAllNotifationByFalse()
		{
			return Ok(_notificationService.TGetAllNotifationByFalse());
		}
		[HttpGet("{id}")]
		public IActionResult GetNotification(int id)
		{
			var value = _notificationService.TGetById(id);
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateNotifacation(CreateNotificationDto createNotificationDto)
		{
			Notification notification = new Notification()
			{
				Date = createNotificationDto.Date,
				Description = createNotificationDto.Description,
				Icon = createNotificationDto.Icon,
				Status = createNotificationDto.Status,
				Type = createNotificationDto.Type,
			};
			_notificationService.TAdd(notification);
			return Ok("Eklema İşlemi Başarılı Şekilde Yapıldı");
		}
		[HttpDelete("{id}")]
		public IActionResult DeleteNotifation(int id)
		{
			_notificationService.TDelete(_notificationService.TGetById(id));
			return Ok("Başarılı Şekilde Silindi");
		}
		[HttpPut]
		public IActionResult UpdateNotifacation(UpdateNotificationDto updateNotificationDto)
		{
			Notification notification = new Notification()
			{
				NotificationId=updateNotificationDto.NotificationId,
				Date = updateNotificationDto.Date,
				Description = updateNotificationDto.Description,
				Icon = updateNotificationDto.Icon,
				Status = updateNotificationDto.Status,
				Type = updateNotificationDto.Type,
			};
			_notificationService.TUpdate(notification);
			return Ok("Güncelleme İşlemi Başarılı Şekilde Yapıldı");
		}
		[HttpGet("NotificationChangeFalse/{id}")]
		public IActionResult NotificationChangeFalse(int id)
		{
			_notificationService.TNotificationChangeFalse(id);
			return Ok("Bildirim durumu değişti");

		}
		[HttpGet("NotificationChangeTrue/{id}")]
		public IActionResult NotificationChangeTrue(int id)
		{
			_notificationService.TNotificationChangeTrue(id);
			return Ok("Bildirim durumu değişti");

		}
	}
}
