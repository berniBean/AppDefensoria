using Clases.DTO.view;
using MediatR;

namespace Clases.helpers
{
    public static class CrearVictima
    {
        public async static Task<string> NuevaVictima(VictimaDTO victima, IMediator _mediator)
        {
            var idVictima = await _mediator.Send(new Clases.Tablas.Victima.Nuevo.Ejecuta()
            {
                Alias = victima.Alias ?? default
            });

            return idVictima;
        }
    }
}
