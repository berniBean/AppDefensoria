using Data.Models;

namespace Clases.DTO.view
{
    public class ReporteDTO
    {
        public string Idreportes { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }
    }
}
