using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Victina
    {
        public string Idvictina { get; set; }
        public string Alias { get; set; }
        public string ArchivoIdarchivo { get; set; }

        public virtual Archivo ArchivoIdarchivoNavigation { get; set; }
    }
}
