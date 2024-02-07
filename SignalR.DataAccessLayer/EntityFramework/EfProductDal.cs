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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductWithCategory()
        {
           SignalRContext context= new SignalRContext();
            var values = context.Products.Include(p => p.Category).ToList();
            return context.Products.Include(p=>p.Category).ToList();
        }

		public int ProductCount()
		{
            var context = new SignalRContext();
            return context.Products.Count();
		}

		public int ProductCountByCategoryNameDrink()
		{
            var context = new SignalRContext();
            return context.Products.Where(p => p.CategoryId == (context.Categorys.Where(c => c.Name == "İçecek").FirstOrDefault().CatogoryId)).Count();
		}

		public int ProductCountByCategoryNameHamburger()
		{
			var context = new SignalRContext();
			return context.Products.Where(p => p.CategoryId == (context.Categorys.Where(c => c.Name == "Hamburger").FirstOrDefault().CatogoryId)).Count();

		}

		public string ProductNameByMaxPrice()
		{
			var context = new SignalRContext();
			return context.Products.Where(p => p.Price == (context.Products.Max(p => p.Price))).FirstOrDefault().Name;
		}

		public string ProductNameByMinPrice()
		{
			var context = new SignalRContext();
			return context.Products.Where(p => p.Price == (context.Products.Min(p => p.Price))).FirstOrDefault().Name;
		}

		public decimal ProductPriceAvg()
		{
			var context = new SignalRContext();
			return context.Products.Average(p => p.Price);
		}

		public decimal ProductPriceAvgByHamburger()
		{
			var context = new SignalRContext();
			return context.Products.Where(p => p.CategoryId == (context.Categorys.Where(c => c.Name == "Hamburger")).FirstOrDefault().CatogoryId).Average(p => p.Price);
		}
	}
}
