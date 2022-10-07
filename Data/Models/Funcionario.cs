using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Funcionario
    {
        public Funcionario()
        {
            Peticionarios = new HashSet<Peticionario>();
        }

        public string IdFuncionario { get; set; }
        public string PersonaIdPersona { get; set; }
        public string OficinaIdoficina { get; set; }
        public string CargoIdcargo { get; set; }

        public virtual Cargo CargoIdcargoNavigation { get; set; }
        public virtual Oficina OficinaIdoficinaNavigation { get; set; }
        public virtual Persona PersonaIdPersonaNavigation { get; set; }
        public virtual ICollection<Peticionario> Peticionarios { get; set; }
    }
}
