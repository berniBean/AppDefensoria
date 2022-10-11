using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Fiscalia
{
    public class Consulta
    {
        public class Ejecuta : IRequest<FiscaliaDTO>
        {
            public string Idfiscalia { get; set; }
        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, FiscaliaDTO>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<FiscaliaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                 var fiscal =await _unitOfWork.Fiscalia.GetAsync(request.Idfiscalia);

                var mapper = _mapper.Map<Data.Models.Fiscalium, FiscaliaDTO>(fiscal);

                return mapper;

            
            }
        }
    }
}
