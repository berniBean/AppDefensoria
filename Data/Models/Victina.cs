using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Victina
    {
        public Victina()
        {
            Archivos = new HashSet<Archivo>();
        }

        public string Idvictina { get; set; }
        public string Alias { get; set; }

        public virtual ICollection<Archivo> Archivos { get; set; }
    }
}
