using Data;

namespace Clases.DTO.TableViews
{
    public class RegistroCitasDGView
    {
        public DateTime? FechaAudiencia { get; set; }
        public string Sala { get; set; }
        public string Audiencia { get; set; }
        public string Delito { get; set; }
        public string ProcesoPenal { get; set; }
        public EstatusArchivo Estatus { get; set; }

    }
}
