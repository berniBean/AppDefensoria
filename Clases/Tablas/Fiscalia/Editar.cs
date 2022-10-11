using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Fiscalia
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            public string Idfiscalia { get; set; }
            public string Adscripcion { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var registro = await _unitOfWork.Fiscalia.GetAsync(request.Idfiscalia);

                registro.Adscripcion = request.Adscripcion ?? registro.Adscripcion;

                 _unitOfWork.Fiscalia.Upadate(registro);

                return RestultadoEF.Salvado(await _unitOfWork.Fiscalia.SaveAsync());


            }
        }
    }
}
