using Clases.DTO.view;
using MediatR;

namespace Clases.helpers
{
    public static class CrearParticulares
    {
       
        public async static Task<string> NuevoPartculares(string _IdPeticionario,IMediator _mediator)
        {
            var idParticulares = await _mediator.Send(new Clases.Tablas.Particulares.Nuevo.Ejecuta()
            {
                IdPeticionario = _IdPeticionario
            });

            return idParticulares;
        }
    }
}
