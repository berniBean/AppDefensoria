using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Fiscalia
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<string>
        {
            public string Adscripcion { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta,string>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<string> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevaFiscalia = new Data.Models.Fiscalium
                {
                    Idfiscalia = Guid.NewGuid().ToString(),
                    Adscripcion = request.Adscripcion
                };

                await _unitOfWork.Fiscalia.AddAsync(nuevaFiscalia);

                return nuevaFiscalia.Idfiscalia;
            }


        }
    }
}
