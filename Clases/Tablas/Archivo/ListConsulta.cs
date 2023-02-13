using AutoMapper;
using AutoMapper.QueryableExtensions;
using Clases.ClasesBase;
using Clases.DTO.TableViews;
using Clases.Repository;
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

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, List<CitasDGView>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<List<CitasDGView>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                //var ArchivoPeticionario = await _context.Archivos.
                //Where(x=>x.IdPeticionarioNavigation.FuncionarioIdFuncionario.Equals(request.IdFuncionario))
                //.ProjectTo<CitasDGView>(_mapper.ConfigurationProvider).ToListAsync();

                var ArchivoPeticionario = await _unitOfWork.Archivo
                    .ObtenerAsync(a => a.IdPeticionarioNavigation.FuncionarioIdFuncionario.Equals(request.IdFuncionario));
                
                 
                var citas = await ArchivoPeticionario.ProjectTo<CitasDGView>(_mapper.ConfigurationProvider).ToListAsync();

                    

                return citas;
            }
        }
    }
}
