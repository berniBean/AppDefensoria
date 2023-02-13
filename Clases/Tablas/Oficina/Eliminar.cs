using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Oficina
{
    public class Eliminar
    {
        public class Ejecuta : IRequest
        {
            public string? IdOficina { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                //var registro = await _context.Oficinas.FirstOrDefaultAsync(x => x.Idoficina.Equals(request.IdOficina));
                var registro = await _unitOfWork.Oficina.ConsultAsync(o => o.Idoficina.Equals(request.IdOficina));

                _unitOfWork.Oficina.DeleteAsync(registro.Idoficina).Wait();
                
                

                return RestultadoEF.Salvado(await _unitOfWork.Save());
            }
        }
    }
}
