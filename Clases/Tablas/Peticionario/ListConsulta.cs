using AutoMapper;
using AutoMapper.QueryableExtensions;
using Clases.ClasesBase;
using Clases.DTO.TableViews;
using Clases.Repository;
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
        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, List<PeticionarioParticularesDGView>>
        {
            //public Handler(ednita_dbContext context, IMapper mapper) : base(context, mapper)
            //{
            //}

            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<List<PeticionarioParticularesDGView>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {

                try
                {



                    var project = await _unitOfWork.Archivo.ObtenerAsync(a => a.IdPeticionarioNavigation.FuncionarioIdFuncionario.Equals(request.IdFuncionario));


                   var mapper = await project.ProjectTo<PeticionarioParticularesDGView>(_mapper.ConfigurationProvider).ToListAsync();
                    
                    


                    if (project == null)
                        throw new Exception("aun no existen Registros");

                   

                    return mapper;
                }
                catch (Exception )
                {

                    throw ;
                }




                

            }
        }
    }
}
