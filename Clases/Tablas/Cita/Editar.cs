﻿using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Cita
{
    public class Editar
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
                var registro = await _unitOfWork.Cita.GetAsync(request.Idcitas);

                registro.FechaAudiencia = request.FechaAudiencia ?? registro.FechaAudiencia;
                registro.Sala = request.Sala ?? registro.Sala;
                registro.Audiencia = request.Audiencia ?? registro.Audiencia;
                registro.ArchivoIdarchivo = request.ArchivoIdarchivo ?? registro.ArchivoIdarchivo;
                registro.ArchivoReportesIdreportes = request.ArchivoReportesIdreportes ?? registro.ArchivoReportesIdreportes;

                return RestultadoEF.Salvado(await _unitOfWork.Cita.SaveAsync());

            }
        }
    }
}