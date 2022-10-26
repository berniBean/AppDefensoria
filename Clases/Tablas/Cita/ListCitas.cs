

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
        public class Ejecuta : IRequest<List<CitasDGView>>
        {
           public string IdFuncionario { get; set; }
        }
        //public class Handler : HandlerRequestMapperBase, IRequestHandler<Ejecuta, List<CitasDGView>>
        //{
        //    public Handler(ednita_dbContext context, IMapper mapper) : base(context, mapper)
        //    {
        //    }

        //    public Task<List<CitasDGView>> Handle(Ejecuta request, CancellationToken cancellationToken)
        //    {
        //        var citas = _context.Citas.Include(cita => cita.ArchivoIdarchivoNavigation)
        //            .ThenInclude(peticionario => peticionario.IdPeticionarioNavigation.PersonaIdPersonaNavigation)                    
        //            .Include(reportes => reportes.ReportesIdreportesNavigation)
        //            .Where(filtro => filtro.ArchivoIdarchivoNavigation.IdPeticionarioNavigation
        //            .FuncionarioIdFuncionario.Equals(request.IdFuncionario));
                    
                    
                    

                
        //        return citas;
        //    }
        //}
    }

    
}
