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
            CreateMap<Data.Models.Persona, PersonaDTO>();
            CreateMap<Data.Models.Archivo, ArchivoDTO>();
            CreateMap<Data.Models.Cita, CitaDTO>();
            CreateMap<Data.Models.Fiscalium, FiscaliaDTO>();
            CreateMap<Data.Models.Victina, VictimaDTO>();
            CreateMap<Data.Models.Observacione,ObservacionesDTO>();
            CreateMap<List<Data.Models.Persona>,List<PersonaDTO>>();

        }
    }
}
