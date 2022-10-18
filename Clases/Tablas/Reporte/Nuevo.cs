using Clases.ClasesBase;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Reporte
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<string>
        {           
            public DateTime? Fecha { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta, string>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<string> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevoReporte = new Data.Models.Reporte
                {
                    Idreportes = Guid.NewGuid().ToString(),
                    Fecha = request.Fecha
                };

                await _unitOfWork.Reporte.AddAsync(nuevoReporte);
                return nuevoReporte.Idreportes;
            }
        }
    }
}
