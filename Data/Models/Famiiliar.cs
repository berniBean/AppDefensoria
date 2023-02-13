using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Famiiliar
    {
        public string PersonaIdPersona { get; set; }
        public string PeticionarioIdPeticionario { get; set; }

        public virtual Persona PersonaIdPersonaNavigation { get; set; }
        public virtual Peticionario PeticionarioIdPeticionarioNavigation { get; set; }
    }
}
