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

        public virtual Archivo ArchivoIdarchivoNavigation { get; set; }
    }
}
