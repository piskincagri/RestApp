using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignaIR.DtoLayer.DiscountDto;
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
    public class DiscountController : ControllerBase
    {

        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult DiscountList()
        {

            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);

        }

        [HttpPost]

        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Title = createDiscountDto.Title,
                Amount = createDiscountDto.Amount,
                Description = createDiscountDto.Description,
                ImageUrl = createDiscountDto.ImageUrl,
                Status= false

            });

            return Ok("İndirim bilgileri eklendi");


        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {

            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("İndirim bilgileri silindi");


        }

        [HttpGet("{id}")]

        public IActionResult GetDiscount(int id)

        {

            var value = _discountService.TGetByID(id);
            return Ok(value);

        }

        [HttpPut]

        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)

        {
            _discountService.TUpdate(new Discount()
            {
                DiscountID= updateDiscountDto.DiscountID,
                Title = updateDiscountDto.Title,
                Amount = updateDiscountDto.Amount,
                Description = updateDiscountDto.Description,
                ImageUrl = updateDiscountDto.ImageUrl,
                Status=false

            });
            return Ok("İndirim Bilgileri Güncellendi");
        }

        [HttpGet("ChangeStatusToTrue/{id}")]
        public IActionResult ChangeStatusToTrue(int id)
        {
            _discountService.TChangeStatusToTrue(id);
            return Ok("Ürün indirimi aktif hale geldi");

        }

        [HttpGet("ChangeStatusToFalse/{id}")]
        public IActionResult ChangeStatusToFalse(int id)
        {
            _discountService.TChangeStatusToFalse(id);
            return Ok("Ürün indirimi pasif hale geldi");

        }

        [HttpGet("GetListByStatusTrue")]

        public IActionResult GetListByStatusTrue()
        {
                        
            return Ok(_discountService.TGetListByStatusTrue());

        }

    }
}
