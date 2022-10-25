using AutoMapper;
using Clases.DTO.TableViews;
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



            CreateMap<Data.Models.Archivo, CitasDGView>()
                .ForMember(peticionario => peticionario.Apaterno, y => y.MapFrom(src => src.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Apaterno))
                .ForMember(peticionario => peticionario.Amaterno, y => y.MapFrom(src => src.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Amaterno))
                .ForMember(peticionario => peticionario.Nombre, y => y.MapFrom(src => src.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Nombre))
                .ForMember(peticionario => peticionario.Domicilio, y=> y.MapFrom(src => src.IdPeticionarioNavigation.Domicilio))
                .ForMember(peticionario => peticionario.Lengua, y => y.MapFrom(src => src.IdPeticionarioNavigation.Lengua))
                .ForMember(peticionario => peticionario.Telefono, y => y.MapFrom(src => src.IdPeticionarioNavigation.Telefono))
                .ForMember(peticionario => peticionario.Edad, y => y.MapFrom(src => src.ParticularesIdParticularesNavigation.Edad))
                .ForMember(peticionario => peticionario.Ocupacion, y => y.MapFrom(src => src.ParticularesIdParticularesNavigation.Ocupacion))
                .ForMember(peticionario => peticionario.EstadoCivil, y => y.MapFrom(src => src.ParticularesIdParticularesNavigation.EstadoCivil))
                .ForMember(peticionario => peticionario.Estudios, y => y.MapFrom(src => src.ParticularesIdParticularesNavigation.Estudios));


            CreateMap<Data.Models.Cita, CitasDGView>();

        }
    }
}
