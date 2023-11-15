using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignaIR.DtoLayer.FeatureDto;
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
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

      
        [HttpGet]

        public IActionResult FeatureList()
        {

            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(value);

        }

        [HttpPost]

        public IActionResult CreateFeature(CreateFeatureDto createfeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                
                Title1= createfeatureDto.Title1,
                Title2 = createfeatureDto.Title2,
                Title3 = createfeatureDto.Title3,
                Description1=createfeatureDto.Description1,
                Description2=createfeatureDto.Description2,
                Description3=createfeatureDto.Description3,

            });

            return Ok("Öneçıkanlar bilgileri eklendi");


        }

        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {

            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Öneçıkanlar bilgileri silindi");


        }

        [HttpGet("GetFeature")]

        public IActionResult GetFeature(int id)

        {

            var value = _featureService.TGetByID(id);
            return Ok(value);

        }

        [HttpPut]

        public IActionResult UpdateFeature(UpdateFeatureDto updatefeatureDto)

        {
            _featureService.TUpdate(new Feature()
            {
                FeatureID=updatefeatureDto.FeatureID,
                Title1 = updatefeatureDto.Title1,
                Title2 = updatefeatureDto.Title2,
                Title3 = updatefeatureDto.Title3,
                Description1 = updatefeatureDto.Description1,
                Description2 = updatefeatureDto.Description2,
                Description3 = updatefeatureDto.Description3,

            });
            return Ok("Öneçıkanlar Bilgileri Güncellendi");
        }



    }
}
