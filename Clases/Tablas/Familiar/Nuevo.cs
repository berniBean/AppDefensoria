using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Familiar
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string IdPersona { get; set; }
            public string IdPeticionario { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevoFamiliar = new Data.Models.Famiiliar
                {
                    PersonaIdPersona = request.IdPersona,
                    PeticionarioIdPeticionario = request.IdPeticionario
                };

                await _unitOfWork.Familiar.AddAsync(nuevoFamiliar);

                return RestultadoEF.Salvado(await _unitOfWork.Save());
            }
        }
    }
}
