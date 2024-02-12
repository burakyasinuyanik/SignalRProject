using SignalR.EntityLayer.Entities;

namespace SignalRWebUi.Dtos.ProductDtos
{
	public class ResultProductDto
	{
		public int ProductId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImgUrl { get; set; }
		public bool Status { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
      
    }
}
