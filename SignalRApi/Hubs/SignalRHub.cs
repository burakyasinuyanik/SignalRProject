using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using System.Formats.Asn1;

namespace SignalRApi.Hubs
{
	public class SignalRHub:Hub
	{
		private readonly ICategoryService _categoryService;
		private readonly IProductService _productService;
		private readonly IOrderService _orderService;
		private readonly IMoneyCaseService _moneyCaseService;
		private readonly IMenuTableService _menuTableService;
		private readonly IBookingService _bookingService;
		private readonly INotificationService _notificationService;
		public SignalRHub(ICategoryService categoryService, IProductService productService, IOrderService orderService, IMoneyCaseService moneyCaseService, IMenuTableService menuTableService, IBookingService bookingService, INotificationService notificationService)
		{
			_categoryService = categoryService;
			_productService = productService;
			_orderService = orderService;
			_moneyCaseService = moneyCaseService;
			_menuTableService = menuTableService;
			_bookingService = bookingService;
			_notificationService = notificationService;
		}

		public async Task SendStatistic()
		{
			var value = _categoryService.TCategoryCount();
			await Clients.All.SendAsync("ReceiveCategoryCount", value);
			var value2 = _productService.TProductCount();
			await Clients.All.SendAsync("ReceiveProductCount", value2);
			var value3 = _categoryService.TActiveCategoryCount();
			await Clients.All.SendAsync("ReceiveActiveCategoryCount", value3);
			var value4 = _categoryService.TPassiveCategoryCount();
			await Clients.All.SendAsync("ReceivePassiveCategoryCount", value4);
			var value5 = _productService.TProductCountByCategoryNameHamburger();
			await Clients.All.SendAsync("ReceiveProductCountByCategoryNameHamburger", value5);
			var value6 = _productService.TProductCountByCategoryNameDrink();
			await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", value6);
			var value7 = _productService.TProductPriceAvg().ToString("0.00")+ " <span> &#8378</span>";
			await Clients.All.SendAsync("ReceiveProductPriceAvg", value7);
			var value8 = _productService.TProductNameByMaxPrice();
			await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", value8);
			var value9 = _productService.TProductNameByMinPrice();
			await Clients.All.SendAsync("ReceiveProductNameByMinPrice", value9);
			var value10 = _productService.TProductAvgPriceByHamburger().ToString("0.00")+" ₺";
			await Clients.All.SendAsync("ReceiveAvgPriceByHamburger", value10);
			var value11 = _orderService.TTotalOrderCount();
			await Clients.All.SendAsync("ReceiveTotalOrderCount", value11);
			var value12 = _orderService.TActiveOrderCount();
			await Clients.All.SendAsync("ReceiveActiveOrderCount", value12);
			var value13 = _orderService.TLastOrderPrice().ToString("0.00") + " ₺";
			await Clients.All.SendAsync("ReceiveLastOrderPrice", value13);
			var value14 = _moneyCaseService.TTotalMoneyCaseAmount().ToString("0.00") + " ₺";
			await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value14);


			var value16 = _menuTableService.MenuTableCount();
			await Clients.All.SendAsync("ReceivemMenuTableCount", value16);
		}

		public async Task SendProgress()
		{
			var value = _moneyCaseService.TTotalMoneyCaseAmount().ToString("0.00")+" ₺";
			await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", value);

			var value2 = _orderService.TActiveOrderCount();
			await Clients.All.SendAsync("ReceiveActiveOrderCount", value2);


			var value3 = _menuTableService.MenuTableCount();
			await Clients.All.SendAsync("ReceiveMenuTableCount", value3);

		}
		public async Task SendGetBookingList()
		{
			var value = _bookingService.TGetListAll();
			await Clients.All.SendAsync("ReceiveGetBookingList", value);
		}
		public async Task SendNotification()
		{
			var value = _notificationService.TNatificationCountByStatusFalse();
			await Clients.All.SendAsync("ReceiveNotificationCountByFalse", value);
			var valueList = _notificationService.TGetAllNotifationByFalse();
		
			await Clients.All.SendAsync("ReceiveNotifationByFalseList", valueList);
		}
		public async Task GetListMenuTableByStatus()
		{
			var value = _menuTableService.TGetListAll();
			await Clients.All.SendAsync("ReceiveMenuTableByStatus", value);
		}
	}
}
