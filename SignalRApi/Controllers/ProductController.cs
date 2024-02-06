using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {

            var values = _mapper.Map<List<ResultProducDto>>(_productService.TGetListAll());
            return Ok(values);
        }
        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {

            var values = _mapper.Map<List<ResultProductWithCategoryDto>>(_productService.TGetProductWithCategory);
            return Ok(values);
        }
        [HttpGet("ProductCountByCategoryNameDrink")]
        public IActionResult ProductCountByCategoryNameDrink()
        {
            return Ok(_productService.TProductCountByCategoryNameDrink());
        }
		[HttpGet("ProductCountByCategoryHamburgerDrink")]
		public IActionResult ProductCountByCategoryNameHamburger()
		{
			return Ok(_productService.TProductCountByCategoryNameHamburger());
		}
        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }
        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            return Ok(_productService.TProductNameByMinPrice());
        }
		[HttpGet("ProductNameByMaxPrice")]
		public IActionResult ProductNameByMaxPrice()
		{
			return Ok(_productService.TProductNameByMaxPrice());
		}

		[HttpPost]
        public IActionResult CreateProduct(CreateProducDto createProducDto)
        {
            Product product = new Product()
            {
              Description = createProducDto.Description,
              ImgUrl= createProducDto.ImgUrl,
              Name= createProducDto.Name,
              Price = createProducDto.Price,
              Status = createProducDto.Status,
              CategoryId = createProducDto.CategoryId,

            };

            _productService.TAdd(product);
            return Ok("Ürün Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Ürün Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {

            _productService.TUpdate(new Product()
            {
                Description = updateProductDto.Description,
                ImgUrl = updateProductDto.ImgUrl,
                Name = updateProductDto.Name,
                Price = updateProductDto.Price,
                Status = updateProductDto.Status,
                ProductId=updateProductDto.ProductId,
                CategoryId = updateProductDto.CategoryId

            });

            return Ok("Ürün Güncellendi");
        }
    }
}
