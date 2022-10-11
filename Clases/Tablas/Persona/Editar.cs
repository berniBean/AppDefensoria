using Clases.ClasesBase;
using Clases.helpers;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Persona
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            public string? IdPersona { get; set; }
            public string? Apaterno { get; set; }
            public string? Amaterno { get; set; }
            public string? Nombre { get; set; }
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
                var registro = await _mediator.Send(new Consulta.Ejecuta() { IdPersona = request.IdPersona });


                registro.Apaterno = request.Apaterno ?? registro.Apaterno;
                registro.Amaterno = request.Amaterno ?? registro.Amaterno;
                registro.Nombre = request.Nombre ?? registro.Nombre;

                
                return RestultadoEF.Salvado(await _context.SaveChangesAsync());
            }
        }
    }
}
