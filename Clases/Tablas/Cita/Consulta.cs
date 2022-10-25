using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Cita
{
    public class Consulta
    {
        public class Ejecuta : IRequest<CitaDTO>
        {
            public string? IdCIta { get; set; }
        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, CitaDTO>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<CitaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var registro = await _unitOfWork.Cita.GetAsync(request.IdCIta);

                var mapper = _mapper.Map<Data.Models.Cita, CitaDTO>(registro);

                return mapper;

            }
        }
    }
}
