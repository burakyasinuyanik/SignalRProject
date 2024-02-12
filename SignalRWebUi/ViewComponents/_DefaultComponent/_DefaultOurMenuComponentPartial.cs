using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SignalRWebUi.Dtos.CategoryDtos;
using SignalRWebUi.Dtos.ProductDtos;

namespace SignalRWebUi.ViewComponents._DefaultComponent
{
    public class _DefaultOurMenuComponentPartial:ViewComponent
    {
       
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultOurMenuComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7294/api/Product");
            var responseMessage2 = await client.GetAsync("https://localhost:7294/api/Category");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData2= await responseMessage2.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                var values2 = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData2);
                ViewData["Category"] = values2.ToList();
                return View(values);
            }
            return View();

           
        }
    }
}
