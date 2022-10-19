using Clases.DTO.view;
using MediatR;

namespace Clases.helpers
{
    public static class CrearVictima
    {
        public async static Task<string> NuevaVictima( IMediator _mediator)
        {
            var idVictima = await _mediator.Send(new Clases.Tablas.Victima.Nuevo.Ejecuta());

            return idVictima;
        }
    }
}
