using System.ComponentModel.DataAnnotations;

namespace SignalR.EntityLayer.Entities
{
    public class Category
    {
        [Key]

        public int CatogoryId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
