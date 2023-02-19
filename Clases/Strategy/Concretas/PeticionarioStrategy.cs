using Clases.DTO.view;
using Clases.Strategy.Intefaces;
using MediatR;

namespace Clases.Strategy.Concretas
{
    public class PeticionarioStrategy : IGuardarStrategy<PersonaDTO>
    {
        //"5df131f7-4bc1-11ed-975f-f4ee08b6e8c4"
        public string? Funcionario { get; set; }
        private IMediator _mediator;

        public PeticionarioStrategy(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Guardar(PersonaDTO persona)
        {
            var IdPersona = await helpers.CrearPersona.NuevaPersona(persona, _mediator);

            var Idpeticionario = await _mediator.Send(new Clases.Tablas.Peticionario.Nuevo.Ejecuta()
            {
                PersonaIdPersona = IdPersona,
                FuncionarioIdFuncionario = Funcionario
            }) ;


            var IdParticulares = await helpers.CrearParticulares.NuevoPartculares(Idpeticionario, _mediator);

            var archivo = await _mediator.Send(new Clases.Tablas.Archivo.Nuevo.Ejecuta()
            {
                IdPeticionario = Idpeticionario,
                ParticularesIdParticulares =IdParticulares,

            });


        }
    }
}
