using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Cita
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string Idcitas { get; set; }
            public DateTime? FechaAudiencia { get; set; }
            public string Sala { get; set; }
            public string Audiencia { get; set; }
            public string ArchivoIdarchivo { get; set; }
            public string ArchivoReportesIdreportes { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevaCita = new Data.Models.Cita
                {
                    Idcitas = Guid.NewGuid().ToString(),
                    FechaAudiencia = request.FechaAudiencia,
                    Sala = request.Sala,
                    Audiencia = request.Audiencia,
                    ArchivoIdarchivo = request.ArchivoIdarchivo,
                    ArchivoReportesIdreportes = request.ArchivoReportesIdreportes

                };

                await _unitOfWork.Cita.AddAsync(nuevaCita);

                return RestultadoEF.Salvado(await _unitOfWork.Cita.SaveAsync());
            }
        }
    }
}
