#nullable disable

namespace Data.Models
{
    public partial class Cita
    {
        public string? Idcitas { get; set; }
        public DateTime? FechaAudiencia { get; set; }
        public string Sala { get; set; }
        public string Audiencia { get; set; }
        public string ResultadoAudiencia { get; set; }
        public string ReportesIdreportes { get; set; }
        public string ArchivoIdarchivo { get; set; }

        public virtual Archivo ArchivoIdarchivoNavigation { get; set; }
        public virtual Reporte ReportesIdreportesNavigation { get; set; }
    }
}
