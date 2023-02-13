using AutoMapper;
using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using Data;
using MediatR;

namespace Clases.Tablas.Peticionario
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            public string IdPeticionario { get; set; }
            public string Alias { get; set; }
            public string IdentidadResguardada { get; set; }
            public string Domicilio { get; set; }
            public string GrupoEtnico { get; set; }
            public SexoPeticionario sexoPeticionario { get; set; }
            public string Lengua { get; set; }
            public string Telefono { get; set; }

        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var registro = await _unitOfWork.Peticionario.GetAsync(request.IdPeticionario);


                if (registro == null)
                    throw new Exception("No se encontró el registro");

                //registro.Alias = request.Alias ?? registro.Alias;
                //registro.IdentidadResguardada = request.IdentidadResguardada ?? registro.IdentidadResguardada;
                registro.Domicilio = request.Domicilio ?? registro.Domicilio;
                registro.GrupoEtnico = request.GrupoEtnico ?? registro.GrupoEtnico;
                registro.SexoPeticionario = request.sexoPeticionario;
                registro.Lengua = request.Lengua ?? registro.Lengua;
                registro.SexoPeticionario = request.sexoPeticionario;
                registro.Telefono = request.Telefono ?? registro.Telefono;


                _unitOfWork.Peticionario.Upadate(registro);

                return RestultadoEF.Salvado(await _unitOfWork.Peticionario.SaveAsync());


            }
        }
    }
}
