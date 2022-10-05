using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Peticionario
    {
        public Peticionario()
        {
            Archivos = new HashSet<Archivo>();
            Particulares = new HashSet<Particulare>();
        }

        public string IdPeticionario { get; set; }
        public string Domicilio { get; set; }
        public string GrupoEtnico { get; set; }
        public string Lengua { get; set; }
        public string Telefono { get; set; }
        public string PersonaIdPersona { get; set; }

        public virtual Persona PersonaIdPersonaNavigation { get; set; }
        public virtual ICollection<Archivo> Archivos { get; set; }
        public virtual ICollection<Particulare> Particulares { get; set; }
    }
}
