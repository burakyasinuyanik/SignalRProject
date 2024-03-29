﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
	public interface INotificationDal:IGenericDal<Notification>
	{
		public int NatificationCountByStatusFalse();
		List<Notification> GetAllNotifationByFalse();
		void NotificationChangeTrue(int id);
		void NotificationChangeFalse(int id);

	}
}
