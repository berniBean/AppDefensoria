using Clases.ClasesBase;
using Clases.helpers;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Cargo
{
    public class Editar 
    {
        public class Ejecuta : IRequest
        {
            public string? Idcargo { get; set; }
            public string? Puesto { get; set; }
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
                var registro = await _mediator.Send(new Consulta.Ejecuta() { IdCargo = request.Idcargo });

                registro.Puesto = request.Puesto ?? registro.Puesto;

                return RestultadoEF.Salvado(await _context.SaveChangesAsync());
                
            }
        }
    }
}
