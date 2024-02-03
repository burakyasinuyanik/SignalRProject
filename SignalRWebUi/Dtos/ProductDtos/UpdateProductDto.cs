namespace SignalRWebUi.Dtos.ProductDtos
{
	public class UpdateProductDto
	{
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImgUrl { get; set; }
		public bool Status { get; set; }
		public int CategoryId { get; set; }
	}
}
