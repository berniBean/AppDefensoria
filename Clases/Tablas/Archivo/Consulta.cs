using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Archivo
{
    public class Consulta
    {
        public class Ejecuta : IRequest<ArchivoDTO>
        {
            public string Idarchivo { get; set; }
        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, ArchivoDTO>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<ArchivoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var archivo = await _unitOfWork.Archivo.GetAsync(request.Idarchivo);
                if (archivo == null)
                    throw new Exception("No se encontró el registro");

                var mapper = _mapper.Map<Data.Models.Archivo, ArchivoDTO>(archivo);
                return mapper;

            }
        }
    }
}
