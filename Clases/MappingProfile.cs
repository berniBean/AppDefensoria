using AutoMapper;
using Clases.DTO.view;

namespace Clases
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Data.Models.Oficina, OficinaDTO>();
            CreateMap<Data.Models.Cargo, CargoDTO>();
        }
    }
}
