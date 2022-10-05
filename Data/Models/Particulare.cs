using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Particulare
    {
        public string IdParticulares { get; set; }
        public int? Edad { get; set; }
        public string Ocupacion { get; set; }
        public string EstadoCivil { get; set; }
        public string Estudios { get; set; }
        public string PeticionarioIdPeticionario { get; set; }

        public virtual Peticionario PeticionarioIdPeticionarioNavigation { get; set; }
    }
}
