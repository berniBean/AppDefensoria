

using AutoMapper;
using AutoMapper.QueryableExtensions;
using Clases.ClasesBase;
using Clases.DTO.TableViews;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Cita
{
    public class ListCitas
    {
        public class Ejecuta : IRequest<List<RegistroCitasDGView>>
        {
           public string IdFuncionario { get; set; }
           public string IdArchivo { get; set; }
        }
        public class Handler : HandlerRequestMapperBase, IRequestHandler<Ejecuta, List<RegistroCitasDGView>>
        {
            public Handler(ednita_dbContext context, IMapper mapper) : base(context, mapper)
            {
            }

            public Task<List<RegistroCitasDGView>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var citas = _context.Citas.Where(x => x.ArchivoIdarchivoNavigation.IdPeticionarioNavigation.FuncionarioIdFuncionario.Equals(request.IdFuncionario)
                                            && x.ArchivoIdarchivo.Equals(request.IdArchivo))
                            .ProjectTo<RegistroCitasDGView>(_mapper.ConfigurationProvider).ToListAsync();





                return citas;
            }
        }
    }

    
}
