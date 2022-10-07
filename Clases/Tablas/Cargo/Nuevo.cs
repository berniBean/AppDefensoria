using Clases.ClasesBase;
using Clases.helpers;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Cargo
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {           
            public string? Puesto { get; set; }
        }

        public class Handler : HandlerRequestBase, IRequestHandler<Ejecuta>
        {
            public Handler(ednita_dbContext context) : base(context)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevoPuesto = new Data.Models.Cargo
                {
                    Idcargo = Guid.NewGuid().ToString(),
                    Puesto = request.Puesto

                };
                await _context.Cargos.AddAsync(nuevoPuesto);
                await _context.SaveChangesAsync();

                return RestultadoEF.Salvado(await _context.SaveChangesAsync());
            }
        }
    }
}
