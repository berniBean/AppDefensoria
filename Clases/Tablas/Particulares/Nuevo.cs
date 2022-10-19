using Clases.ClasesBase;
using Clases.DTO.view;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Particulares
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<string>
        {
            public string IdPeticionario { get; set; }
            
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta, string>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<string> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var particulares = new Data.Models.Particulare
                {
                    IdParticulares = Guid.NewGuid().ToString(),
                    IdPeticionario = request.IdPeticionario
                };

                await _unitOfWork.Particulares.AddAsync(particulares);
                await _unitOfWork.Save();
                return particulares.IdParticulares;
            }
        }
    }
}
