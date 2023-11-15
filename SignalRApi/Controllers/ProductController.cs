using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]

        public IActionResult CreateProduct(CreateProductDto createproductDto)
        {
            _productService.TAdd(new Product()
            {

               ProductName=createproductDto.ProductName,
               Description=createproductDto.Description,
               Price=createproductDto.Price,
               ImageURL=createproductDto.ImageURL,
               ProductStatus=createproductDto.ProductStatus

            });

            return Ok("Ürün bilgileri eklendi");


        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {

            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün bilgileri silindi");


        }

        [HttpGet("GetProduct")]

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
                ProductStatus = updateproductDto.ProductStatus

            });
            return Ok("Ürün Bilgileri Güncellendi");
        }



    }
}
