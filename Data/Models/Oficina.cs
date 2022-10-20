using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Oficina
    {
        public Oficina()
        {
            Funcionarios = new HashSet<Funcionario>();
        }

        public string Idoficina { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
