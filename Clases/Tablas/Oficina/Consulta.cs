using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Oficina
{
    public class Consulta
    {
       public class Ejecuta : EjecutaRespuestaGen<OficinaDTO>
        {
            public string? IdOficina { get; set; }
        }

        public class Handler : HandlerRequestMapperBase, IRequestHandler<Ejecuta,OficinaDTO>
        {
            public Handler(ednita_dbContext context, IMapper mapper) : base(context, mapper)
            {
            }


            public async Task<OficinaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var oficina =  await _context.Oficinas.FirstOrDefaultAsync(x => x.Idoficina.Equals(request.IdOficina));

                var mapper = _mapper.Map<Data.Models.Oficina, OficinaDTO>(oficina);

                return mapper;
            }
        }
    }
}
