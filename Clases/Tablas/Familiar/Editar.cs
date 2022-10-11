using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Familiar
{
    public class Editar
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
                var registro = await _unitOfWork.Familiar.GetAsync(request.IdPeticionario);

                if (registro == null)
                    throw new Exception("No se encontró el registro");

                registro.PersonaIdPersona = request.IdPersona ?? registro.PersonaIdPersona;
                registro.PeticionarioIdPeticionario = request.IdPeticionario ?? registro.PeticionarioIdPeticionario;

                _unitOfWork.Familiar.Upadate(registro);

                return RestultadoEF.Salvado(await _unitOfWork.Cargo.SaveAsync());
            }
        }
    }
}
