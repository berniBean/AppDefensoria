using AutoMapper;
using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Archivo
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {   
            public string Persona { get; set; }
            public int? Serieindevep { get; set; }
            public string Delito { get; set; }
            public string Carpeta { get; set; }
            public string Juez { get; set; }
            public string ProcesoPenal { get; set; }
            public string SegundaInstancia { get; set; }
            public string Toca { get; set; }
            public string Amparo { get; set; }
            public string ExpedinteAmparo { get; set; }
            public string Estatus { get; set; }
            public string IdPeticionario { get; set; }
            public string FiscaliaIdfiscalia { get; set; }
            public string ReportesIdreportes { get; set; }
            public string ParticularesIdParticulares { get; set; }
            public string VictinaIdvictina { get; set; }
            

        }

        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var archivo = new Data.Models.Archivo
                {
                    Idarchivo = Guid.NewGuid().ToString(),
                    Serieindevep = request.Serieindevep,
                    Delito = request.Delito,
                    Carpeta = request.Carpeta,
                    Juez = request.Juez,
                    ProcesoPenal = request.ProcesoPenal,
                    SegundaInstancia = request.SegundaInstancia,
                    Toca = request.Toca,
                    Amparo = request.Amparo,
                    ExpedinteAmparo = request.ExpedinteAmparo,
                    Estatus = request.Estatus,
                    IdPeticionario = request.IdPeticionario,
                    FiscaliaIdfiscalia = request.FiscaliaIdfiscalia,
                    ReportesIdreportes = request.ReportesIdreportes,
                    ParticularesIdParticulares = request.ParticularesIdParticulares,
                    VictinaIdvictina = request.VictinaIdvictina
                };

                

                await _unitOfWork.Archivo.AddAsync(archivo);

                return RestultadoEF.Salvado(await _unitOfWork.Archivo.SaveAsync());
            }
        }
    }
}
