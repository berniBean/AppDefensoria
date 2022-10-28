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
            CreateMap<Data.Models.Particulare, ParticularesDto>();



            CreateMap<Data.Models.Archivo, PeticionarioParticularesDGView>()
                .ForMember(dto => dto.Ocupacion, ent => ent.MapFrom(prop => prop.ParticularesIdParticularesNavigation.Ocupacion))
                .ForMember(dto => dto.Estudios, ent => ent.MapFrom(prop => prop.ParticularesIdParticularesNavigation.Estudios))
                .ForMember(dto => dto.Nombre, ent => ent.MapFrom(prop => prop.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Nombre))
                .ForMember(dto => dto.Apaterno, ent => ent.MapFrom(prop => prop.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Apaterno))
                .ForMember(dto => dto.Amaterno, ent => ent.MapFrom(prop => prop.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Amaterno))
                .ForMember(dto => dto.Domicilio, ent => ent.MapFrom(prop => prop.IdPeticionarioNavigation.Domicilio))
                .ForMember(dto => dto.Lengua, ent => ent.MapFrom(prop => prop.IdPeticionarioNavigation.Lengua))
                .ForMember(dto => dto.Telefono, ent => ent.MapFrom(prop => prop.IdPeticionarioNavigation.Telefono))
                .ForMember(dto => dto.Edad, ent => ent.MapFrom(prop => prop.ParticularesIdParticularesNavigation.Edad))
                .ForMember(dto => dto.Ocupacion, ent => ent.MapFrom(prop => prop.ParticularesIdParticularesNavigation.Ocupacion))
                .ForMember(dto => dto.EstadoCivil, ent => ent.MapFrom(prop => prop.ParticularesIdParticularesNavigation.EstadoCivil))
                .ForMember(dto => dto.Estudios, ent => ent.MapFrom(prop => prop.ParticularesIdParticularesNavigation.Estudios));
                




            CreateMap<Data.Models.Archivo, CitasDGView>()
                .ForMember(dto => dto.Nombre, ent => ent.MapFrom(prop => prop.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Nombre))
                .ForMember(dto => dto.Apaterno, ent => ent.MapFrom(prop => prop.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Apaterno))
                .ForMember(dto => dto.Amaterno, ent => ent.MapFrom(prop => prop.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Amaterno));

            CreateMap<Data.Models.Cita, RegistroCitasDGView>()
                .ForMember(dto => dto.Delito, ent => ent.MapFrom(prop => prop.ArchivoIdarchivoNavigation.Delito))
                .ForMember(dto => dto.ProcesoPenal, ent => ent.MapFrom(prop => prop.ArchivoIdarchivoNavigation.ProcesoPenal))
                .ForMember(dto => dto.Estatus, ent => ent.MapFrom(prop => prop.ArchivoIdarchivoNavigation.Estatus));
                
        }
    }
}
