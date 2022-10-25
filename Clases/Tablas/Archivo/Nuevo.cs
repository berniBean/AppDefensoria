using AutoMapper;
using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Archivo
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<string>
        {   
            public string IdPeticionario { get; set; }
            public string ParticularesIdParticulares { get; set; }
            

        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta,string>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<string> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                try
                {
                    var archivo = new Data.Models.Archivo
                    {
                        Idarchivo = Guid.NewGuid().ToString(),
                        IdPeticionario = request.IdPeticionario,                      
                        ParticularesIdParticulares = request.ParticularesIdParticulares
                    };



                    await _unitOfWork.Archivo.AddAsync(archivo);
                    await _unitOfWork.Save();

                    return archivo.Idarchivo;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
