#nullable disable

namespace Data.Models
{
    public partial class Particulare
    {
        public Particulare()
        {
            Archivos = new HashSet<Archivo>();
        }

        public string IdParticulares { get; set; }
        public int? Edad { get; set; }
        public string Ocupacion { get; set; }
        public string EstadoCivil { get; set; }
        public string Estudios { get; set; }
        public string IdPeticionario { get; set; }

        public virtual ICollection<Archivo> Archivos { get; set; }
    }
}
