using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Observaciones
{
    public class Consulta
    {
        public class EJecuta : IRequest<ObservacionesDTO>
        {
            public string Idobservaciones { get; set; }
        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<EJecuta, ObservacionesDTO>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<ObservacionesDTO> Handle(EJecuta request, CancellationToken cancellationToken)
            {
                var observacion = await _unitOfWork.Observaciones.GetAsync(request.Idobservaciones);

                if (observacion == null)
                    throw new Exception("No se encotraron registros");

               var mapper= _mapper.Map<Data.Models.Observacione, ObservacionesDTO>(observacion);
                return mapper;
            }
        }
    }
}
