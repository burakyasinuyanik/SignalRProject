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
	public class MoneyCaseManager : IMoneyCaseService
	{
		private readonly IMoneyCasesDal _moneyCasesDal;

		public MoneyCaseManager(IMoneyCasesDal moneyCasesDal)
		{
			_moneyCasesDal = moneyCasesDal;
		}

		public void TAdd(MoneyCase entity)
		{
			_moneyCasesDal.Add(entity);
		}

		public void TDelete(MoneyCase entity)
		{
			_moneyCasesDal.Delete(entity);
		}

		public MoneyCase TGetById(int id)
		{
			return _moneyCasesDal.GetById(id);
		}

		public List<MoneyCase> TGetListAll()
		{
			return _moneyCasesDal.GetListAll();
		}

		public decimal TTotalMoneyCaseAmount()
		{
			return _moneyCasesDal.TotalMoneyCaseAmount();

		}

		public void TUpdate(MoneyCase entity)
		{
			_moneyCasesDal.Update(entity);
		}
	}
}
