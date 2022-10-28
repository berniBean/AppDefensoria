using Data;

namespace Clases.DTO.TableViews
{
    public class RegistroCitasDGView
    {
        public DateTime? FechaAudiencia { get; set; }
        public string Sala { get; set; }
        public string Audiencia { get; set; }
        public TipoAtencion tipoAtencion { get; set; }
        public string Delito { get; set; }
        public string ProcesoPenal { get; set; }
        public string ResultadoAudiencia { get; set; }
        public EstatusArchivo Estatus { get; set; }

    }
}
