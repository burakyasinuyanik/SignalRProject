using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
    public class Basket
    {
        [Key]
        public int BasketId { get; set; }
        public decimal Price { get; set; }
        public decimal Count { get; set;}
        public decimal TotalPrice { get; set;}
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int MenuTableId { get; set; }
        public virtual MenuTable MenuTable { get; set; }
    }
}
