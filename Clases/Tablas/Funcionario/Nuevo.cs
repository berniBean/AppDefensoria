using Clases.ClasesBase;
using Clases.helpers;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Funcionario
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string? IdFuncionario { get; set; }
            public string? PersonaIdPersona { get; set; }
            public string? OficinaIdoficina { get; set; }
            public string? CargoIdcargo { get; set; }
        }

        public class Handler : HandlerRequestBase, IRequestHandler<Ejecuta>
        {
            private readonly IMediator _mediator;
            public Handler(ednita_dbContext context, IMediator mediator) : base(context)
            {
                _mediator = mediator;
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var persona = await _mediator.Send(new Tablas.Persona.Consulta.Ejecuta() { IdPersona = request.PersonaIdPersona });
                var oficina = await _mediator.Send(new Tablas.Oficina.Consulta.Ejecuta() { IdOficina = request.OficinaIdoficina });
                var cargo = await _mediator.Send(new Tablas.Cargo.Consulta.Ejecuta() { IdCargo = request.CargoIdcargo }); 
                
                var nuevoFuncionaro = new Data.Models.Funcionario
                {
                    IdFuncionario = Guid.NewGuid().ToString(),
                    PersonaIdPersona = persona.IdPersona,
                    OficinaIdoficina = oficina.Idoficina,
                    CargoIdcargo = cargo.Idcargo
                };

                await _context.Funcionarios.AddRangeAsync(nuevoFuncionaro);
                await _context.SaveChangesAsync();

                return RestultadoEF.Salvado(await _context.SaveChangesAsync());
            }
        }
    }
}
