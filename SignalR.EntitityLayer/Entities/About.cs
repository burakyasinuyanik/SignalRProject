using System.ComponentModel.DataAnnotations;

namespace SignalR.EntityLayer.Entities
{
    public class About
    {
        [Key]

        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
    }

