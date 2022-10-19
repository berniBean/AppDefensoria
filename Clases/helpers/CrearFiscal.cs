using Clases.DTO.view;
using MediatR;

namespace Clases.helpers
{
    public static class CrearFiscal
    {
        public async static Task<string> NuevoFiscal(IMediator _mediator)
        {
            var idFiscal = await _mediator.Send(new Clases.Tablas.Fiscalia.Nuevo.Ejecuta());

            return idFiscal;


        }
    }
}
