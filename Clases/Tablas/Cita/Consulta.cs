using AutoMapper;
using AutoMapper.QueryableExtensions;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Cita
{
    public class Consulta
    {
        public class Ejecuta : IRequest<CitaDTO>
        {
            public string? IdArchivo { get; set; }
        }

        public class Handler : HandlerRequestMapperBase, IRequestHandler<Ejecuta, CitaDTO>
        {
            public Handler(ednita_dbContext context, IMapper mapper) : base(context, mapper)
            {
            }

            public async Task<CitaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var registro = await _context.Citas.FirstOrDefaultAsync(x => x.ArchivoIdarchivo.Equals(request.IdArchivo));

                var map = _mapper.Map<CitaDTO>(registro);

                return map;

            }
        }
    }
}
