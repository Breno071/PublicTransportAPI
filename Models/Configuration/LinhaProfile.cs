﻿using AutoMapper;
using PublicTransportAPI.Models.DTOS;

namespace PublicTransportAPI.Models.Configuration
{
    public class LinhaProfile : Profile
    {
        public LinhaProfile()
        {
            CreateMap<TbLinha, LinhaDTO>().ReverseMap();
        }
    }
}
