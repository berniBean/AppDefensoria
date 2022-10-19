using Clases.DTO.view;
using Clases.Strategy.Intefaces;
using MediatR;

namespace Clases.Strategy.Concretas
{


    public class ArchivoNuevoStrategy : IGuardarStrategy<ArchivoDTO>
    {
        private IMediator _mediator;

        public ArchivoNuevoStrategy(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Guardar(ArchivoDTO persona)
        {
            var res = await _mediator.Send(new Clases.Tablas.Archivo.Nuevo.Ejecuta()
            {

                IdPeticionario = persona.IdPeticionario
            });
        }
    }
}
