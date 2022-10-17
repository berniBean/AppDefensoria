using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Persona
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<string>
        {
            public string? Apaterno { get; set; }
            public string? Amaterno { get; set; }
            public string? Nombre { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta,string>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<string> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevaPersona = new Data.Models.Persona
                {
                    IdPersona = Guid.NewGuid().ToString(),
                    Apaterno = request.Apaterno,
                    Amaterno = request.Amaterno,
                    Nombre = request.Nombre

                };

                await _unitOfWork.Persona.AddAsync(nuevaPersona);
                await _unitOfWork.Save();

                return nuevaPersona.IdPersona.ToString();
            }
        }

    }
}
