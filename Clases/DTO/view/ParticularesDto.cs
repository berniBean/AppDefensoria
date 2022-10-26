using Data.Models;

namespace Clases.DTO.view
{
    public class ParticularesDto
    {

        public int? Edad { get; set; }
        public string Ocupacion { get; set; }
        public string EstadoCivil { get; set; }
        public string Estudios { get; set; }

        public virtual ICollection<ArchivoDTO> Archivos { get; set; }


    }
}
