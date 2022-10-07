using Clases.ClasesBase;
using Clases.helpers;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Oficina
{
    public class Eliminar
    {
        public class Ejecuta : IRequest
        {
            public string? IdOficina { get; set; }
        }

        public class Handler : HandlerRequestBase, IRequestHandler<Ejecuta>
        {
            public Handler(ednita_dbContext context) : base(context)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var registro = await _context.Oficinas.FirstOrDefaultAsync(x => x.Idoficina.Equals(request.IdOficina));

                _context.Oficinas.Remove(registro);

                return RestultadoEF.Salvado(await _context.SaveChangesAsync());
            }
        }
    }
}
