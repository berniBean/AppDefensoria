using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Observacione
    {
        public string Idobservaciones { get; set; }
        public string Resultados { get; set; }
        public string ArchivoIdarchivo { get; set; }
        public string ArchivoIdarchivo1 { get; set; }
        public string ArchivoReportesIdreportes { get; set; }

        public virtual Archivo Archivo { get; set; }
    }
}
