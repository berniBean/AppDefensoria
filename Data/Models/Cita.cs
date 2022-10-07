using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Cita
    {
        public string Idcitas { get; set; }
        public DateTime? FechaAudiencia { get; set; }
        public string Sala { get; set; }
        public string Audiencia { get; set; }
        public string ArchivoIdarchivo { get; set; }
        public string ArchivoReportesIdreportes { get; set; }

        public virtual Archivo Archivo { get; set; }
    }
}
