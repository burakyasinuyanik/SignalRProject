using System.ComponentModel.DataAnnotations;

namespace SignalR.EntityLayer.Entities
{
    public class Discount
    {
        [Key]

        public int DiccountId { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public bool status { get; set; }
    }
}
