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
            Famiiliars = new HashSet<Famiiliar>();
        }

        public string IdPeticionario { get; set; }
        public string Alias { get; set; }
        public string IdentidadResguardada { get; set; }
        public string Domicilio { get; set; }
        public string GrupoEtnico { get; set; }
        public string Lengua { get; set; }
        public string Telefono { get; set; }
        public string PersonaIdPersona { get; set; }
        public string FuncionarioIdFuncionario { get; set; }
        public SexoPeticionario SexoPeticionario { get; set; }

        public virtual Funcionario FuncionarioIdFuncionarioNavigation { get; set; }
        public virtual Persona PersonaIdPersonaNavigation { get; set; }
        public virtual ICollection<Archivo> Archivos { get; set; }
        public virtual ICollection<Famiiliar> Famiiliars { get; set; }
    }
}
