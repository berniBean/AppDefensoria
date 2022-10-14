using MediatR;

namespace Clases.DTO.view
{
    public class ObservacionesDTO
    {
        public class EJecuta : IRequest<ObservacionesDTO>
        {
            public string Idobservaciones { get; set; }
            public string Resultados { get; set; }
            public string ArchivoIdarchivo { get; set; }
            public string ArchivoIdarchivo1 { get; set; }
            public string ArchivoReportesIdreportes { get; set; }
        }
    }
}
