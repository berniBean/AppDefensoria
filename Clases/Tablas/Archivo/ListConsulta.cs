using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.TableViews;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Archivo
{
    public class ListConsulta
    {
        public class Ejecuta : IRequest<List<CitasDGView>>
        {
            public string? IdFuncionario { get; set; }
        }

        public class Handler : HandlerRequestMapperBase, IRequestHandler<Ejecuta, List<CitasDGView>>
        {
            public Handler(ednita_dbContext context, IMapper mapper) : base(context, mapper)
            {
            }

            public async Task<List<CitasDGView>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var ArchivoPeticionario = await _context.Archivos.Where(funcionario => funcionario.IdPeticionarioNavigation.FuncionarioIdFuncionario.Equals(request.IdFuncionario))
                    .Include(peticionario => peticionario.IdPeticionarioNavigation.PersonaIdPersonaNavigation)
                    .Include(particulares => particulares.ParticularesIdParticularesNavigation)
                    .ToListAsync();
            }
        }
    }
}
