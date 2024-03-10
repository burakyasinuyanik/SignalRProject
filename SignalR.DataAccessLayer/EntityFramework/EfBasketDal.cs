using Microsoft.EntityFrameworkCore;
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
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(SignalRContext context) : base(context)
        {
        }

        public List<Basket> GetBasketByMenuTable(int id)
        {
            var context = new SignalRContext();
			List<Basket> basket=context.Baskets.Where(b => b.MenuTableId == id).Include(y => y.Product).ToList();
            List < Basket > basketList = new List<Basket>();
            bool itemAddPrice = true;
            int asilList = 0;
			foreach (Basket item in basket)
            {
                asilList = basket.Where(b => b.ProductId == item.ProductId).First().ProductId;

				if (item.ProductId==asilList)
                {
                    var value =basketList.FirstOrDefault(item => item.ProductId == asilList);
                    if (!basketList.Contains(value))
                    {
						basketList.Add(item);
						itemAddPrice = false;
					}
					
                }
                if (itemAddPrice)
                {
					var value = basketList.Where(b=>b.ProductId==item.ProductId).FirstOrDefault();
					value.Price += item.Price;
                    value.Count++;
                    value.TotalPrice += item.Price;
				}
                itemAddPrice = true;
                
            }

            return basketList;
        }
    }
}
