

using AutoMapper;
using AutoMapper.QueryableExtensions;
using Clases.ClasesBase;
using Clases.DTO.TableViews;
using Clases.Repository;
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
        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, List<RegistroCitasDGView>>
        {
            
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
                
            }


            public async Task<List<RegistroCitasDGView>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                //var citas = _DbContext.Citas.Where(x => x.ArchivoIdarchivoNavigation.IdPeticionarioNavigation.FuncionarioIdFuncionario.Equals(request.IdFuncionario)
                //                            && x.ArchivoIdarchivo.Equals(request.IdArchivo))
                //            .ProjectTo<RegistroCitasDGView>(_mapper.ConfigurationProvider).ToListAsync();

                //return citas;

                var citas2 = await _unitOfWork.Cita.ObtenerAsync(c => c.ArchivoIdarchivoNavigation.IdPeticionarioNavigation.FuncionarioIdFuncionario.Equals(request.IdFuncionario)
                                && c.ArchivoIdarchivo.Equals(request.IdArchivo));

                var map = _mapper.Map<List<RegistroCitasDGView>>(citas2); 

                return map;
            }
        }
    }

    
}
