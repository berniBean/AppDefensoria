using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.TableViews;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Peticionario
{
    public class ListConsulta
    {
        public class Ejecuta : IRequest<List<PeticionarioParticularesDGView>>
        {
            public string? IdFuncionario { get; set; }
        }
        public class Handler : HandlerRequestMapperBase, IRequestHandler<Ejecuta, List<PeticionarioParticularesDGView>>
        {
            public Handler(ednita_dbContext context, IMapper mapper) : base(context, mapper)
            {
            }

            public async Task<List<PeticionarioParticularesDGView>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {


                var ArchivoPeticionario = await _context.Archivos.Include(peticionario => peticionario.IdPeticionarioNavigation)
                    .ThenInclude(funcionario => funcionario.FuncionarioIdFuncionarioNavigation)
                    .ThenInclude(persona => persona.PersonaIdPersonaNavigation)
                    .Where(funcionario => funcionario.IdPeticionarioNavigation.FuncionarioIdFuncionario.Equals(request.IdFuncionario)).ToListAsync();

                if (ArchivoPeticionario == null)
                    throw new Exception("aun no existen Registros");


                var mapper = _mapper.Map<List<Data.Models.Archivo>, List<PeticionarioParticularesDGView>>(ArchivoPeticionario);

                return mapper.ToList();

            }
        }
    }
}
