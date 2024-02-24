using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
	public interface INotificationService:IGenericService<Notification>
	{
		int TNatificationCountByStatusFalse();
		List<Notification> TGetAllNotifationByFalse();
		void TNotificationChangeTrue(int id);
		void TNotificationChangeFalse(int id);
	}
}
