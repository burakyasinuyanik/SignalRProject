using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.EntityLayer.Entities
{
	public class OrderDetail
	{
		[Key]
        public int OrderDetailId { get; set; }
		public int ProductId { get; set; }
		public Product Product { get; set; }
		public int Count { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal TotalPrice { get; set; }
		public int OrderId { get; set; }
		public Order Order { get; set; }

	}
}
