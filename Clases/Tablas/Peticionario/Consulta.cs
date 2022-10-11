using Clases.ClasesBase;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Peticionario
{
    public class Consulta
    {
        public class Ejecuta : IRequest<Data.Models.Peticionario>
        {
            public string IdPeticionario { get; set; }
        }
        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta, Data.Models.Peticionario>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Data.Models.Peticionario> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var resultado = await _unitOfWork.Peticionario.GetAsync(request.IdPeticionario);

                return resultado;
                  
            }
        }
    }
}
