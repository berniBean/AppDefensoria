using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Victima
{
    public class Consulta
    {
        public class Ejecuta : IRequest<VictimaDTO>
        {
            public string Idvictina { get; set; }
            
        }

        public class Handeler : HandlerMapperOfWork, IRequestHandler<Ejecuta, VictimaDTO>
        {
            public Handeler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<VictimaDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var victima = await _unitOfWork.Victima.GetAsync(request.Idvictina);
                if (victima == null) { throw new Exception("no se econtró el registro"); }

                var mapper = _mapper.Map<Data.Models.Victina, VictimaDTO>(victima);

                return mapper;
            }
        }
    }
}
