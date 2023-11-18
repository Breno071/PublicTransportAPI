using AutoMapper;
using PublicTransportAPI.Models;

namespace PublicTransportAPI.Mappers.Configuration
{
    public class PosicaoVeiculoProfile : Profile
    {
        public PosicaoVeiculoProfile()
        {
            CreateMap<PosicaoVeiculo, PosicaoVeiculoProfile>().ReverseMap();
        }
    }
}
