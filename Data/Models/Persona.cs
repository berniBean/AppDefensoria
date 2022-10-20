using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Famiiliars = new HashSet<Famiiliar>();
            Funcionarios = new HashSet<Funcionario>();
            Peticionarios = new HashSet<Peticionario>();
        }

        public string IdPersona { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Famiiliar> Famiiliars { get; set; }
        public virtual ICollection<Funcionario> Funcionarios { get; set; }
        public virtual ICollection<Peticionario> Peticionarios { get; set; }
    }
}
