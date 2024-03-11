using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SignalRWebUi.Dtos.MailDtos;
using System.Net;
using System.Net.Mail;

namespace SignalRWebUi.Controllers
{
	public class MailController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(CreateMailDto createMailDto)
		{
			MailMessage mailMessage	= new MailMessage("thisrakyazilim@gmail.com", createMailDto.ReceiverEmail,createMailDto.Subject,createMailDto.Body);
			mailMessage.IsBodyHtml = true;

			SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential("thisrakyazilim@gmail.com", "zbawppdgecuqnwjx");
			smtpClient.Send(mailMessage);

			return RedirectToAction("Index","Category");
		}
	}
}
