using Clases.DTO.view;
using Clases.Strategy.Intefaces;
using MediatR;

namespace Clases.Strategy.Concretas
{
    public class FamiliarStrategy : IGuardarStrategy<PersonaDTO>
    {
        public string? Peticionario { get; set; }
        private IMediator _mediator;


        public FamiliarStrategy(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Guardar(PersonaDTO persona)
        {
            try
            {
                var IdPersona = await helpers.CrearPersona.NuevaPersona(persona, _mediator);

                var familiar = await _mediator.Send(new Clases.Tablas.Familiar.Nuevo.Ejecuta()
                {
                    IdPersona = IdPersona,
                    IdPeticionario = Peticionario
                }) ;
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrio un error en: "+ e) ;
            }


        }
    }
}
