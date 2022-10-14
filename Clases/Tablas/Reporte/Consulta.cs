using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Reporte
{
    public class Consulta
    {
        public class Ejecuta : IRequest<VictimaDTO>
        {
            public string Idreportes { get; set; }
        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, VictimaDTO>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<VictimaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var consulta = await _unitOfWork.Victima.GetAsync(request.Idreportes);

                var mapper = _mapper.Map<Data.Models.Victina, VictimaDTO>(consulta);

                return mapper;
            }
        }
    }
}
