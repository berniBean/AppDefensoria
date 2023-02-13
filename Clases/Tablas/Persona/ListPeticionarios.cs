using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
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

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, List<PersonaDTO>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<List<PersonaDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                //var peticionarios = await _context.Personas.Where(x => x.IdPersona.Equals(request.IdDefensor))
                //    .Include(x => x.Peticionarios).ToListAsync();
                //if (peticionarios.Any())
                //    throw new Exception("No existen registros de peticionarios");
                try
                {
                    var peticionarios = await _unitOfWork.Persona.ObtenerAsync(p => p.IdPersona.Equals(request.IdDefensor));
                    await peticionarios.Include(x => x.Peticionarios).ToListAsync();
                    if (peticionarios.Any())
                        throw new Exception("No existen registros de peticionarios");

                    var mapper = _mapper.Map<List<PersonaDTO>>(peticionarios);

                    return mapper;
                }
                catch (Exception)
                {

                    throw;
                }





                

                
            
            
            }
        }
    }
}
