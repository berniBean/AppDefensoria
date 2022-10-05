using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Cita
    {
        public Cita()
        {
            Archivos = new HashSet<Archivo>();
        }

        public string Idcitas { get; set; }
        public DateTime? FechaAudiencia { get; set; }
        public string Sala { get; set; }
        public string Audiencia { get; set; }

        public virtual ICollection<Archivo> Archivos { get; set; }
    }
}
