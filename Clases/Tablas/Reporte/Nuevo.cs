using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Reporte
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string Idreportes { get; set; }
            public DateTime? Fecha { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevoReporte = new Data.Models.Reporte
                {
                    Idreportes = Guid.NewGuid().ToString(),
                    Fecha = request.Fecha
                };

                await _unitOfWork.Reporte.AddAsync(nuevoReporte);
                return RestultadoEF.Salvado(await _unitOfWork.Reporte.SaveAsync());
            }
        }
    }
}
