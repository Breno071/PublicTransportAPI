using AutoMapper;
using PublicTransportAPI.Models;
using PublicTransportAPI.Models.DTOS;

namespace PublicTransportAPI.Mappers.Configuration
{
    public class VeiculoProfile : Profile
    {
        public VeiculoProfile()
        {
            CreateMap<Veiculo, VeiculoDTO>().ReverseMap();
        }
    }
}
