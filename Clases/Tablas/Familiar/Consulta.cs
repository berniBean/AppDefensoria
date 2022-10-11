using Clases.ClasesBase;
using Clases.Repository;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Familiar
{
    public class Consulta
    {
        public class Ejecuta : IRequest<Data.Models.Famiiliar>
        {
            public string IdFamiliar { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta, Famiiliar>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public Task<Famiiliar> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
               var registro= _unitOfWork.Familiar.GetAsync(request.IdFamiliar);
                if (registro == null)
                    throw new Exception("No se encontró el registro");

                return registro;

            }
        }
    }
}
