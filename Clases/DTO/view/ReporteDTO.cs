using Data.Models;

namespace Clases.DTO.view
{
    public class ReporteDTO
    {
        public string Idreportes { get; set; }

        public virtual ICollection<CitaDTO> Cita { get; set; }
    }
}
