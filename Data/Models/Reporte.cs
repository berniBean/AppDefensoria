using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Reporte
    {
        public Reporte()
        {
            Archivos = new HashSet<Archivo>();
        }

        public string Idreportes { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual ICollection<Archivo> Archivos { get; set; }
    }
}
