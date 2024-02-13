using SignalR.EntityLayer.Entities;

namespace SignalRWebUi.Dtos.BasketDtos
{
    public class ResultBasketDto
    {
        public int BasketId { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int MenuTableId { get; set; }
        public virtual MenuTable MenuTable { get; set; }

    }
}
