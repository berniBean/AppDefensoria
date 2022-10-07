using Clases.ClasesBase;
using Clases.helpers;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Oficina
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {           
            public string? Nombre { get; set; }
            public string? Abreviatura { get; set; }
        }

        public class Handler : HandlerRequestBase, IRequestHandler<Ejecuta>
        {
            public Handler(ednita_dbContext context) : base(context)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevaOficina = new Data.Models.Oficina
                {
                    Idoficina = Guid.NewGuid().ToString(),
                    Nombre = request.Nombre,
                    Abreviatura = request.Abreviatura

                };

                await _context.Oficinas.AddRangeAsync(nuevaOficina);
                await _context.SaveChangesAsync();

               return RestultadoEF.Salvado(await _context.SaveChangesAsync());

            }
        }
    }
}
