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
	public class EfNatificationDal : GenericRepository<Notification>, INatificationDal
	{
		public EfNatificationDal(SignalRContext context) : base(context)
		{
		}

		public int NatificationCountByStatusFalse()
		{
			var context = new SignalRContext();
			return context.Notifications.Where(n => n.Status == false).Count();
		}
	}
}
