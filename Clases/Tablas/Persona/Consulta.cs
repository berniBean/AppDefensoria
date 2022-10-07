using Clases.ClasesBase;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Persona
{
    public class Consulta 
    {
        public class Ejecuta : EjecutaRespuestaGen<Data.Models.Persona>
        {
            public string? IdPersona { get; set; }
        }

        public class Handler : HandlerRequestBase, IRequestHandler<Ejecuta, Data.Models.Persona>
        {
            public Handler(ednita_dbContext context) : base(context)
            {
            }

            public async Task<Data.Models.Persona> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var persona = await _context.Personas.FirstOrDefaultAsync(x => x.IdPersona.Equals(request.IdPersona));
                return persona;
            }
        }
    }
}
