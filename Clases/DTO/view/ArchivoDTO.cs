using Data.Models;

namespace Clases.DTO.view
{
    public class ArchivoDTO
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
        public string Fiscalia { get; set; }
        public string Victima { get; set; }
        public string IdPeticionario { get; set; }
        public string ReportesIdreportes { get; set; }
        public string ParticularesIdParticulares { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
    }
}
