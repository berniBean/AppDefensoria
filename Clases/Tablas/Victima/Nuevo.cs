using Clases.ClasesBase;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Victima
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<string>
        {
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta, string>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<string> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevaVictima = new Data.Models.Victina
                {
                    Idvictina = Guid.NewGuid().ToString(),


                };

               await _unitOfWork.Victima.AddAsync(nuevaVictima);
               await _unitOfWork.Save();
                return nuevaVictima.Idvictina;
            }
        }
    }
}
