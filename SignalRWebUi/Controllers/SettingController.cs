using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalRWebUi.Dtos.IdentityDtos;

namespace SignalRWebUi.Controllers
{
	public class SettingController : Controller
	{
		private readonly UserManager<AppUser> _userManager;

		public SettingController(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpGet]
		public async Task< ActionResult> Index()
		{
			var value = await _userManager.FindByNameAsync(User.Identity.Name);
			UpdateUserDto updateUserDto = new UpdateUserDto();
			updateUserDto.Name = value.Name;
			updateUserDto.Surname = value.SurName;
			updateUserDto.Mail = value.Email;
			updateUserDto.UserName = value.UserName;

			return View(updateUserDto);
		}
		[HttpPost]
		public async Task<ActionResult> Index(UpdateUserDto updateUserDto)
		{
			if (updateUserDto.Password == updateUserDto.ConfirmPassword)
			{
				var value = await _userManager.FindByNameAsync(User.Identity.Name);
				value.Name=updateUserDto.Name;
				value.SurName = updateUserDto.Surname;
				value.UserName = updateUserDto.UserName;
				value.Email = updateUserDto.Mail;
				value.PasswordHash = _userManager.PasswordHasher.HashPassword(value, updateUserDto.Password);
				var result = await _userManager.UpdateAsync(value);
				return RedirectToAction("Index", "Category");
			}
		

			return View();
		}
	}
}
