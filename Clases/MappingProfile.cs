﻿using AutoMapper;
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
            CreateMap<Data.Models.Fiscalium, FiscaliaDTO>();
            CreateMap<Data.Models.Victina, VictimaDTO>();
            CreateMap<Data.Models.Observacione,ObservacionesDTO>();

            CreateMap<Data.Models.Peticionario, PeticionarioDGView>()
                .ForMember(x => x.Nombre, y => y.MapFrom(src => src.PersonaIdPersonaNavigation.Nombre))
                .ForMember(x => x.Amaterno, y => y.MapFrom(src => src.PersonaIdPersonaNavigation.Amaterno))
                .ForMember(x => x.Apaterno, y => y.MapFrom(src => src.PersonaIdPersonaNavigation.Apaterno))
                .ForMember(x => x.IdPeticionario, y => y.MapFrom(src => src.IdPeticionario))
                .ForMember(x => x.IdPersona, y => y.MapFrom(src => src.PersonaIdPersonaNavigation.IdPersona));


            CreateMap<Data.Models.Archivo, PeticionarioParticularesDGView>()
                .ForMember(peticionario => peticionario.Edad, y => y.MapFrom(src => src.ParticularesIdParticularesNavigation.Edad))
                .ForMember(peticionario => peticionario.Ocupacion, y => y.MapFrom(src => src.ParticularesIdParticularesNavigation.Ocupacion))
                .ForMember(peticionario => peticionario.EstadoCivil, y => y.MapFrom(src => src.ParticularesIdParticularesNavigation.EstadoCivil))
                .ForMember(peticionario => peticionario.Estudios, y => y.MapFrom(src => src.ParticularesIdParticularesNavigation.Estudios))
                .ForMember(peticionario => peticionario.Domicilio, y => y.MapFrom(src => src.IdPeticionarioNavigation.Domicilio))
                .ForMember(peticionario => peticionario.Lengua, y => y.MapFrom(src => src.IdPeticionarioNavigation.Lengua))
                .ForMember(peticionario => peticionario.Telefono, y => y.MapFrom(src => src.IdPeticionarioNavigation.Telefono))
                .ForMember(peticionario => peticionario.Apaterno, y => y.MapFrom(src => src.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Apaterno))
                .ForMember(peticionario => peticionario.Amaterno, y => y.MapFrom(src => src.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Amaterno))
                .ForMember(peticionario => peticionario.Nombre, y => y.MapFrom(src => src.IdPeticionarioNavigation.PersonaIdPersonaNavigation.Nombre))
                .ForMember(peticionario => peticionario.PersonaIdPersona, y => y.MapFrom(src => src.IdPeticionarioNavigation.PersonaIdPersonaNavigation.IdPersona));



        }
    }
}
