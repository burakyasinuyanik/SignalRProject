namespace SignalRWebUi.Dtos.MailDtos
{
	public class CreateMailDto
	{
		public string ReceiverEmail { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
	}
}
