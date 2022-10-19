using Clases.DTO.view;
using MediatR;

namespace Clases.helpers
{
    public static class CrearReporte
    {
        public async static Task<string> NuevoReporte(IMediator _mediator)
        {
            var Nuevoreporte = await _mediator.Send(new Clases.Tablas.Reporte.Nuevo.Ejecuta()) ;

            return Nuevoreporte;
        }
    }
}
