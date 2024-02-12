using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ProductDto
{
    public class ResultProducDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
        public bool Status { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
