using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Reporte
    {
        public Reporte()
        {
            Cita = new HashSet<Cita>();
        }

        public string? Idreportes { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual ICollection<Cita> Cita { get; set; }
    }
}
