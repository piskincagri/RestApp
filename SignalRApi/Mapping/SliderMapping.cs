using AutoMapper;
using SignaIR.DtoLayer.FeatureDto;
using SignaIR.DtoLayer.SliderDto;
using SignaIR.EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRApi.Mapping
{
    public class SliderMapping:Profile
    {
        public SliderMapping()
        {
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
           
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
        }


    }
}
