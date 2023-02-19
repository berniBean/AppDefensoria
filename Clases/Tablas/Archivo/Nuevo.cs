using AutoMapper;
using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Archivo
{
    public class Nuevo
    {
        public class Ejecuta : IRequest<string>
        {
            public string IdPeticionario { get; set; }
            public string ParticularesIdParticulares { get; set; }

            public int? Serieindevep { get; set; }
            public int? Periodo { get; set; }
            public string Delito { get; set; }
            public string Carpeta { get; set; }
            public string Jurisdiccion { get; set; }
            public string Juez { get; set; }
            public string Distrito { get; set; }
            public string ProcesoPenal { get; set; }
            public string SegundaInstancia { get; set; }
            public string Toca { get; set; }
            public string Amparo { get; set; }
            public string ExpedinteAmparo { get; set; }

        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, string>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<string> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                try
                {
                    var archivo = new Data.Models.Archivo
                    {
                        Idarchivo = Guid.NewGuid().ToString(),
                        IdPeticionario = request.IdPeticionario,
                        ParticularesIdParticulares = request.ParticularesIdParticulares,


                        Serieindevep = request.Serieindevep,
                        Periodo = request.Periodo,
                        Delito = request.Delito,
                        Carpeta = request.Carpeta,
                        Jurisdiccion = request.Jurisdiccion,
                        Juez = request.Juez,
                        Distrito = request.Distrito,
                        ProcesoPenal = request.ProcesoPenal,
                        SegundaInstancia = request.SegundaInstancia,
                        Toca = request.Toca,
                        Amparo = request.Amparo,
                        ExpedinteAmparo = request.ExpedinteAmparo

                        
                    };



                    await _unitOfWork.Archivo.AddAsync(archivo);
                    await _unitOfWork.Save();

                    return archivo.Idarchivo;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
