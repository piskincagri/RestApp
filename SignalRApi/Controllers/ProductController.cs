using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignaIR.DataAccessLayer.Concrete;
using SignaIR.DtoLayer.ProductDto;
using SignaIR.EntitiyLayer.Entities;
using SignalR.BussinesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);

        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());

        }

        [HttpGet("ProductNamePriceByMax")]
        public IActionResult ProductNamePriceByMax()
        {
            return Ok(_productService.TProductNamePriceByMax());

        }

        [HttpGet("ProductNamePriceByMin")]
        public IActionResult ProductNamePriceByMin()
        {
            return Ok(_productService.TProductNamePriceByMin());

        }

        [HttpGet(" ProductAvgPriceByHamburger")]
        public IActionResult ProductAvgPriceByHamburger()
        {
            return Ok(_productService.TProductAvgPriceByHamburger());

        }

        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            return Ok(_productService.TProductCountByCategoryNameHamburger());

        }

        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.TProductCountByCategoryNameDrink());

        }

        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());

        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory ()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                Description = y.Description,
                ImageURL = y.ImageURL,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                CategoryName = y.Category.CategoryName

            });
            return Ok (values.ToList());
          

        }



        [HttpPost]

        public IActionResult CreateProduct(CreateProductDto createproductDto)
        {
            _productService.TAdd(new Product()
            {

               ProductName=createproductDto.ProductName,
               Description=createproductDto.Description,
               Price=createproductDto.Price,
               ImageURL=createproductDto.ImageURL,
               ProductStatus=true,
               CategoryID=createproductDto.CategoryID
            });

            return Ok("Ürün bilgileri eklendi");


        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {

            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün bilgileri silindi");


        }

        [HttpGet("{id}")]

        public IActionResult GetProduct(int id)

        {

            var value = _productService.TGetByID(id);
            return Ok(value);

        }

        [HttpPut]

        public IActionResult UpdateProduct(UpdateProductDto updateproductDto)

        {
            _productService.TUpdate(new Product()
            {
                ProductID=updateproductDto.ProductID,
                ProductName = updateproductDto.ProductName,
                Description = updateproductDto.Description,
                Price = updateproductDto.Price,
                ImageURL = updateproductDto.ImageURL,
                ProductStatus = true,
                CategoryID = updateproductDto.CategoryID

            });
            return Ok("Ürün Bilgileri Güncellendi");
        }



    }
}
