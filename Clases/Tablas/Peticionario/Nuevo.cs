using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Peticionario
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            
            public string Alias { get; set; }
            public string IdentidadResguardada { get; set; }
            public string Domicilio { get; set; }
            public string GrupoEtnico { get; set; }
            public string Lengua { get; set; }
            public string Telefono { get; set; }
            public string PersonaIdPersona { get; set; }
            public string FuncionarioIdFuncionario { get; set; }
        }
        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }



            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevo = new Data.Models.Peticionario
                {
                    IdPeticionario = Guid.NewGuid().ToString(),
                    Alias = request.Alias,
                    IdentidadResguardada = request.IdentidadResguardada,
                    Domicilio = request.Domicilio,
                    GrupoEtnico = request.GrupoEtnico,
                    Lengua = request.Lengua,
                    Telefono = request.Telefono,
                    PersonaIdPersona = request.PersonaIdPersona,
                    FuncionarioIdFuncionario = request.FuncionarioIdFuncionario

                };

                await _unitOfWork.Peticionario.AddAsync(nuevo);

                return RestultadoEF.Salvado(await _unitOfWork.Save());
            }
        }
    }
}
