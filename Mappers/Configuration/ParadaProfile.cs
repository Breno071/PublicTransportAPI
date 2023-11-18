using AutoMapper;
using PublicTransportAPI.Models;
using PublicTransportAPI.Models.DTOS;

namespace PublicTransportAPI.Mappers.Configuration
{
    public class ParadaProfile : Profile
    {
        public ParadaProfile()
        {
            CreateMap<Parada, ParadaDTO>().ReverseMap();
        }
    }
}
