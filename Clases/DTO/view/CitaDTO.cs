using Data.Models;

namespace Clases.DTO.view
{
    public class CitaDTO
    {
        public string Idcitas { get; set; }
        //llaves foreaneas
        public string ReportesIdreportes { get; set; }
        public string ArchivoIdarchivo { get; set; }

        //Navegaciones
        public virtual ArchivoDTO ArchivoIdarchivoNavigation { get; set; }
        public virtual ReporteDTO ReportesIdreportesNavigation { get; set; }


    }
}
