namespace SignalRWebUi.Dtos.DiscountDtos

{
	public class GetDiscountDto
    {
        public int DiccountId { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
		public bool status { get; set; }

	}
}
