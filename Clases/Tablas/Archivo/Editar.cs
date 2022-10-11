using Clases.ClasesBase;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Archivo
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            public string Idarchivo { get; set; }
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

        public class Handler : HandlerRequestBase, IRequestHandler<Ejecuta>
        {
            public Handler(ednita_dbContext context) : base(context)
            {
            }

            public Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
