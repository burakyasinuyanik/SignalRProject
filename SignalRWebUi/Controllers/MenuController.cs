using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUi.Dtos.BasketDtos;
using SignalRWebUi.Dtos.CategoryDtos;
using SignalRWebUi.Dtos.ProductDtos;
using System.Text;

namespace SignalRWebUi.Controllers
{
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7294/api/Product");
            var responseMessage2 = await client.GetAsync("https://localhost:7294/api/Category");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                var values2 = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData2);
                ViewData["Category"] = values2.ToList();
                return View(values);
            }
            return View();


        }
        [HttpPost]
        public async Task<IActionResult> AddBasket(CreateBasketDto createBasketDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBasketDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7294/api/Basket", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
