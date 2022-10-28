using Clases.DTO.view;
using Clases.Strategy.Intefaces;
using MediatR;

namespace Clases.Strategy.Concretas
{
    internal class NuevaCitaStrategy : IGuardarStrategy<CitaDTO>
    {
        private IMediator _mediator;

        public NuevaCitaStrategy(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Guardar(CitaDTO persona)
        {
            try
            {
                var NuevaCita =  await _mediator.Send(new Clases.Tablas.Cita.Nuevo.Ejecuta()
                {
                    Sala = persona.Sala,
                    Audiencia = persona.Audiencia,
                    FechaAudiencia = persona.FechaAudiencia,
                    ResultadoAudiencia = persona.ResultadoAudiencia
                });
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
