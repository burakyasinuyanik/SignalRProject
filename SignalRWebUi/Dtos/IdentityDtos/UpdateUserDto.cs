namespace SignalRWebUi.Dtos.IdentityDtos
{
	public class UpdateUserDto
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string UserName { get; set; }
		public string Mail { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
	}
}
