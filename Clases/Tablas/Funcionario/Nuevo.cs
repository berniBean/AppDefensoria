using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Funcionario
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string? IdFuncionario { get; set; }
            public string? IdPersona { get; set; }
            public string? IdOficina { get; set; }
            public string? IdCargo { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var persona = await _unitOfWork.Persona.GetAsync(request.IdPersona);
                var oficina = await _unitOfWork.Oficina.GetAsync(request.IdOficina);
                var cargo = await _unitOfWork.Cargo.GetAsync(request.IdCargo);
                
                var nuevoFuncionaro = new Data.Models.Funcionario
                {
                    IdFuncionario = Guid.NewGuid().ToString(),
                    PersonaIdPersona = persona.IdPersona,
                    OficinaIdoficina = oficina.Idoficina,
                    CargoIdcargo = cargo.Idcargo
                };
                await _unitOfWork.Funcionario.AddAsync(nuevoFuncionaro);

                return RestultadoEF.Salvado(await _unitOfWork.Funcionario.SaveAsync());
            }
        }
    }
}
