using Clases.ClasesBase;
using Clases.helpers;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Oficina
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            public string? IdOficina { get; set; }
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
                var registro = await _context.Oficinas.FirstOrDefaultAsync(x => x.Idoficina.Equals(request.IdOficina));

                registro.Nombre = request.Nombre ?? registro.Nombre;
                registro.Abreviatura = request.Abreviatura ?? registro.Abreviatura;

                return RestultadoEF.Salvado(await _context.SaveChangesAsync());

            }
        }
    }
}
