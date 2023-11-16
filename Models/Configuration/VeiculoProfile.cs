using AutoMapper;
using PublicTransportAPI.Models.DTOS;

namespace PublicTransportAPI.Models.Configuration
{
    public class VeiculoProfile : Profile
    {
        public VeiculoProfile()
        {
            CreateMap<TbVeiculo, VeiculoDTO>().ReverseMap();
        }
    }
}
