using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Particulares
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            public string IdParticulares { get; set; }
            public int? Edad { get; set; }
            public string Ocupacion { get; set; }
            public string EstadoCivil { get; set; }
            public string Estudios { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var registro = await _unitOfWork.Particulares.GetAsync(request.IdParticulares);

                if(registro == null )
                    throw new Exception("El registro no existe");
                registro.Ocupacion = request.Ocupacion ?? registro.Ocupacion;
                registro.EstadoCivil = request.EstadoCivil ?? registro.EstadoCivil;
                registro.Estudios = request.Estudios ?? registro.Estudios;
                registro.Edad = request.Edad ?? registro.Edad;

                _unitOfWork.Particulares.Upadate(registro);

                return RestultadoEF.Salvado(await _unitOfWork.Particulares.SaveAsync());

            }
        }
    }
}
