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
                Serieindevep = persona.Serieindevep,
                Delito = persona.Delito,
                Carpeta = persona.Carpeta,
                Juez = persona.Juez,
                ProcesoPenal = persona.ProcesoPenal,
                SegundaInstancia = persona.SegundaInstancia,
                Toca = persona.Toca,
                Amparo = persona.Amparo,
                ExpedinteAmparo = persona.ExpedinteAmparo,
                IdPeticionario = persona.IdPeticionario,

                


            });
        }
    }
}
