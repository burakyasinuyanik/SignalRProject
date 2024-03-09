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
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal

    {
        public EfDiscountDal(SignalRContext context) : base(context)
        {
        }

		public void ChangeStatusToFalse(int id)
		{
			var context = new SignalRContext();
			var value=context.Discounts.Find(id);
			value.Status = false;
			context.SaveChanges();
		}

		public void ChangeStatusToTrue(int id)
		{
			var context = new SignalRContext();
			var value = context.Discounts.Find(id);
			value.Status = true;
			context.SaveChanges();
		}

		public List<Discount> GetListByStatusTrue()
		{
			var context = new SignalRContext();
			return context.Discounts.Where(d=>d.Status==true).ToList();
		}
	}
}
