using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
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

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta,OficinaDTO>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<OficinaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                try
                {
                    var oficina = await _unitOfWork.Oficina.ConsultAsync(
                        o => o.Idoficina.Equals(request.IdOficina));
                    var map = _mapper.Map<OficinaDTO>(oficina);
                    return map;
                }
                catch (Exception)
                {

                    throw;
                }
                //var oficina =  await _context.Oficinas.FirstOrDefaultAsync(x => x.Idoficina.Equals(request.IdOficina));

                

                //var mapper = _mapper.Map<Data.Models.Oficina, OficinaDTO>(oficina);

                
            }
        }
    }
}
