using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Fiscalium
    {
        public Fiscalium()
        {
            Archivos = new HashSet<Archivo>();
        }

        public int Idfiscalia { get; set; }
        public string Adscripcion { get; set; }

        public virtual ICollection<Archivo> Archivos { get; set; }
    }
}
