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
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {

            var values = _mapper.Map<List<ResultProductWithCategoryDto>>(_productService.TGetProductWithCategory);
            return Ok(values);
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
              Status = createProducDto.Status

            };

            _productService.TAdd(product);
            return Ok("Ürün Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Ürün Silindi");
        }

        [HttpGet("GetProduct")]
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
                ProductId=updateProductDto.ProductId

            });

            return Ok("Ürün Güncellendi");
        }
    }
}
