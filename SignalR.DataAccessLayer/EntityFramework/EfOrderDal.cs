using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{
		private readonly SignalRContext _context;

		public EfOrderDal(SignalRContext context):base(context)
		{
			_context = context;
		}

		public int ActiveOrderCount()
		{
			return _context.Orders.Where(o=>o.Description=="Müşteri Masada").Count();
		}

		public decimal LastOrderPrice()
		{
			return _context.Orders.OrderByDescending(o => o.OrderId).FirstOrDefault().TotalPrice;
		}

		public decimal TodayOrderPrice()
		{
			return _context.Orders.Where(o => o.Date == DateTime.Parse( DateTime.Now.ToShortDateString())).Sum(o => o.TotalPrice);
		}

		public int TotalOrderCount()
		{
			return _context.Orders.Count();
		}
	}
}
