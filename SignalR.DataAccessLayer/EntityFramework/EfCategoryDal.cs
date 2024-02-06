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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SignalRContext context) : base(context)
        {
        }

		public int ActiveCategoryCount()
		{
			var context = new SignalRContext();
			return context.Categorys.Where(c=>c.Status==true).Count();
		}

		public int CategoryCount()
		{
			var context = new SignalRContext();
			return context.Categorys.Count();
		}

		public int PassiveCategoryCount()
		{
			var context = new SignalRContext();
			return context.Categorys.Where(c => c.Status == false).Count();
		}
	}
}
