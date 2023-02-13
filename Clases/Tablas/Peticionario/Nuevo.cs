using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Peticionario
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<string>
        {
            public string? PersonaIdPersona { get; set; }
            public string? FuncionarioIdFuncionario { get; set; }
        }
        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta,string>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<string> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                try
                {
                    var nuevo = new Data.Models.Peticionario
                    {
                        IdPeticionario = Guid.NewGuid().ToString(),
                        PersonaIdPersona = request.PersonaIdPersona,
                        FuncionarioIdFuncionario = request.FuncionarioIdFuncionario

                    };

                    await _unitOfWork.Peticionario.AddAsync(nuevo);

                    return nuevo.IdPeticionario;
                }
                catch (Exception e)
                {

                    throw new Exception(e.ToString());
                }
            }
        }
    }
}
