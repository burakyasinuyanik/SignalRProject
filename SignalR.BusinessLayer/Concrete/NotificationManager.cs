using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
	public class NotificationManager : INotificationService
	{
		private readonly INotificationDal _natificationDal;

	
		public NotificationManager(INotificationDal natificationDal)
		{
			_natificationDal = natificationDal;
		}

		public void TAdd(Notification entity)
		{
			_natificationDal.Add(entity);
		}

		public void TDelete(Notification entity)
		{
			_natificationDal.Delete(entity);
		}

		public List<Notification> TGetAllNotifationByFalse()
		{
			return _natificationDal.GetAllNotifationByFalse();
		}

		public Notification TGetById(int id)
		{
			return _natificationDal.GetById(id);
		}

		public List<Notification> TGetListAll()
		{
			return _natificationDal.GetListAll();
		}

		public int TNatificationCountByStatusFalse()
		{
			return _natificationDal.NatificationCountByStatusFalse();
		}

		public void TNotificationChangeFalse(int id)
		{
			_natificationDal.NotificationChangeFalse(id);
		}

		public void TNotificationChangeTrue(int id)
		{
			_natificationDal.NotificationChangeTrue(id);
		}

		public void TUpdate(Notification entity)
		{
			_natificationDal.Update(entity);
		}
	}
}
