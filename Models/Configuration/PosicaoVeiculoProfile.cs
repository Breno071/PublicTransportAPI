using AutoMapper;

namespace PublicTransportAPI.Models.Configuration
{
    public class PosicaoVeiculoProfile : Profile
    {
        public PosicaoVeiculoProfile()
        {
            CreateMap<TbPosicaoVeiculo, PosicaoVeiculoProfile>().ReverseMap();
        }
    }
}
