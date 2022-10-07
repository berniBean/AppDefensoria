using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Cargo
{
    public class Consulta
    {
        public class Ejecuta : EjecutaRespuestaGen<Data.Models.Cargo>
        {
            public string? IdCargo { get; set; }
        }

        public class Handler : HandlerRequestBase, IRequestHandler<Ejecuta, Data.Models.Cargo>
        {
            public Handler(ednita_dbContext context) : base(context)
            {
            }

            public async Task<Data.Models.Cargo> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var cargo = await _context.Cargos.FirstOrDefaultAsync(x => x.Idcargo.Equals(request.IdCargo));

                

                return cargo;
            }
        }
    }
}
