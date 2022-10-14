using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Persona
{
    public class ListPeticionarios
    {
        public class Ejecuta : IRequest<List<PersonaDTO>>
        {
            public string? IdDefensor { get; set; }
        }

        public class Handler : HandlerRequestMapperBase, IRequestHandler<Ejecuta, List<PersonaDTO>>
        {
            public Handler(ednita_dbContext context, IMapper mapper) : base(context, mapper)
            {
            }

            public async Task<List<PersonaDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var peticionarios = await _context.Personas.Where(x => x.IdPersona.Equals(request.IdDefensor))
                    .Include(x => x.Peticionarios).ToListAsync();
                if (peticionarios.Any())
                    throw new Exception("No existen registros de peticionarios");

                var mapper = _mapper.Map<List<Data.Models.Persona>, List<PersonaDTO>>(peticionarios);

                return mapper;
            
            
            }
        }
    }
}
