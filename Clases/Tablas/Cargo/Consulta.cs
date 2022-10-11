using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Cargo
{
    public class Consulta
    {
        public class Ejecuta : EjecutaRespuestaGen<CargoDTO>
        {
            public string? IdCargo { get; set; }
        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, CargoDTO>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<CargoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var cargo = await _unitOfWork.Cargo.GetAsync(request.IdCargo);

                var mapper = _mapper.Map<Data.Models.Cargo, CargoDTO>(cargo);


                return mapper;
            }
        }
    }
}
