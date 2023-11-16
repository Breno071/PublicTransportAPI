using AutoMapper;
using PublicTransportAPI.Models.DTOS;

namespace PublicTransportAPI.Models.Configuration
{
    public class ParadaProfile : Profile
    {
        public ParadaProfile()
        {
            CreateMap<TbParadum, ParadaDTO>().ReverseMap();
        }
    }
}
