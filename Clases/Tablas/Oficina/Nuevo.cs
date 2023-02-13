using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Oficina
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {           
            public string? Nombre { get; set; }
            public string? Abreviatura { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevaOficina = new Data.Models.Oficina
                {
                    Idoficina = Guid.NewGuid().ToString(),
                    Nombre = request.Nombre,
                    Abreviatura = request.Abreviatura

                };


                await _unitOfWork.Oficina.AddAsync(nuevaOficina);
                
                //await _context.Oficinas.AddRangeAsync(nuevaOficina);
                

               return RestultadoEF.Salvado(await _unitOfWork.Save());

            }
        }
    }
}
