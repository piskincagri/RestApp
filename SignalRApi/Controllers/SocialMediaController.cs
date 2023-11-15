﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignaIR.DtoLayer.SocialMediaDto;
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
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult SocialMediaList()
        {

            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(value);

        }

        [HttpPost]

        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {

                Title = createSocialMediaDto.Title,
                URL = createSocialMediaDto.URL,
                Icon = createSocialMediaDto.Icon
             

            });

            return Ok("Sosyal medya bilgileri eklendi");


        }

        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {

            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Sosyal medya bilgileri silindi");


        }

        [HttpGet("GetSocialMedia")]

        public IActionResult GetSocialMedia(int id)

        {

            var value = _socialMediaService.TGetByID(id);
            return Ok(value);

        }

        [HttpPut]

        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)

        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
                SocialMediaID=updateSocialMediaDto.SocialMediaID,
                Title = updateSocialMediaDto.Title,
                URL = updateSocialMediaDto.URL,
                Icon = updateSocialMediaDto.Icon

            });
            return Ok("Sosyal medya bilgileri Güncellendi");
        }




    }
}
