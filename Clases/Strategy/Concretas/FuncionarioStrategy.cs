using Clases.DTO.view;
using Clases.Strategy.Intefaces;
using MediatR;

namespace Clases.Strategy.Concretas
{
    public class FuncionarioStrategy : IPersonaStrategy<PersonaDTO>
    {
        public string Cargo { get; set; }
        public string Oficina { get; set; }
        public string Funcionario { get; set; }
        private readonly IMediator _mediator;

        public FuncionarioStrategy(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Guardar(PersonaDTO persona)
        {
            try
            {
                var IdPersona = await helpers.CrearPersona.NuevaPersona(persona, _mediator);

                var funcionario = await _mediator.Send(new Clases.Tablas.Funcionario.Nuevo.Ejecuta()
                {
                    IdPersona = IdPersona,
                    IdCargo = Cargo,
                    IdOficina = Oficina,
                    IdFuncionario = Funcionario

                });
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrio un error en: " + e);
            }
            
            
        }
    }
}
