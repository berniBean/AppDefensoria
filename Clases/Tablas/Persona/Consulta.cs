using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Persona
{
    public class Consulta 
    {
        public class Ejecuta : EjecutaRespuestaGen<PersonaDTO>
        {
            public string? IdPersona { get; set; }
        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, PersonaDTO>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<PersonaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var persona = await _unitOfWork.Persona.GetAsync(request.IdPersona);
                if (persona == null)
                    throw new Exception("No se encontró el registro");
                
                var mapper = _mapper.Map<PersonaDTO>(persona);
                return mapper;
            }
        }
    }
}
