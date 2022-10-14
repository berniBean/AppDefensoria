using Clases.ClasesBase;
using Clases.helpers;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Persona
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string? Apaterno { get; set; }
            public string? Amaterno { get; set; }
            public string? Nombre { get; set; }
        }

        public class Handler : HandlerRequestBase, IRequestHandler<Ejecuta>
        {
            public Handler(ednita_dbContext context) : base(context)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevaPersona = new Data.Models.Persona
                {
                    IdPersona = Guid.NewGuid().ToString(),
                    Apaterno = request.Amaterno,
                    Amaterno = request.Amaterno,
                    Nombre = request.Nombre

                };

                await _context.Personas.AddRangeAsync(nuevaPersona);
                await _context.SaveChangesAsync();

                return RestultadoEF.Salvado(await _context.SaveChangesAsync());
            }
        }

    }
}
