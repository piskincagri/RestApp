using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignaIR.DtoLayer.TestimonialDto;
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
    public class TestimonialController : ControllerBase
    {

        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult TestimonialList()
        {

            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);

        }

        [HttpPost]

        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {

                Name = createTestimonialDto.Name,
                Title = createTestimonialDto.Title,
                Comment = createTestimonialDto.Comment,
                ImageURL = createTestimonialDto.ImageURL,
                Status = createTestimonialDto.Status


            });

            return Ok("Müşteri yorum bilgileri eklendi");


        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {

            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Müşteri yorum bilgileri silindi");


        }

        [HttpGet("GetTestimonial")]

        public IActionResult GetTestimonial(int id)

        {

            var value = _testimonialService.TGetByID(id);
            return Ok(value);

        }

        [HttpPut]

        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)

        {
            _testimonialService.TUpdate(new Testimonial()
            {
                TestimonialID=updateTestimonialDto.TestimonialID,
                Name = updateTestimonialDto.Name,
                Title = updateTestimonialDto.Title,
                Comment = updateTestimonialDto.Comment,
                ImageURL = updateTestimonialDto.ImageURL,
                Status = updateTestimonialDto.Status

            });
            return Ok("Müşteri yorum bilgileri Güncellendi");
        }

    }
}
