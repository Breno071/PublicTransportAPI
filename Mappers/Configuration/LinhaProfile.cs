using AutoMapper;
using PublicTransportAPI.Models;
using PublicTransportAPI.Models.DTOS;

namespace PublicTransportAPI.Mappers.Configuration
{
    public class LinhaProfile : Profile
    {
        public LinhaProfile()
        {
            CreateMap<Linha, LinhaDTO>().ReverseMap();
        }
    }
}
