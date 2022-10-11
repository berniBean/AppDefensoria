using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Funcionario
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            public string? IdFuncionario { get; set; }
            public string? PersonaIdPersona { get; set; }
            public string? OficinaIdoficina { get; set; }
            public string? CargoIdcargo { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var registro = await _unitOfWork.Funcionario.GetAsync(request.IdFuncionario);

                if (registro == null)
                    throw new Exception("No se encontró el registro");

                registro.PersonaIdPersona = request.PersonaIdPersona ?? registro.PersonaIdPersona;
                registro.OficinaIdoficina = request.OficinaIdoficina ?? registro.OficinaIdoficina;
                registro.CargoIdcargo = request.CargoIdcargo ?? registro.CargoIdcargo;

                return RestultadoEF.Salvado(await _unitOfWork.Funcionario.SaveAsync()) ;
                
            }
        }
    }
}
