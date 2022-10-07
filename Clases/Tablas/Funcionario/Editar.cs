using Clases.ClasesBase;
using Clases.helpers;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Funcionario
{
    public class Editar
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
                var registro = await _mediator.Send(new Consulta.Ejecuta() { IdFuncionario = request.IdFuncionario });

                registro.PersonaIdPersona = request.PersonaIdPersona ?? registro.PersonaIdPersona;
                registro.OficinaIdoficina = request.OficinaIdoficina ?? registro.OficinaIdoficina;
                registro.CargoIdcargo = request.CargoIdcargo ?? registro.CargoIdcargo;

                return RestultadoEF.Salvado(await _context.SaveChangesAsync());
                
            }
        }
    }
}
