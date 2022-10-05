using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Cargo
    {
        public Cargo()
        {
            Funcionarios = new HashSet<Funcionario>();
        }

        public string Idcargo { get; set; }
        public string Puesto { get; set; }

        public virtual ICollection<Funcionario> Funcionarios { get; set; }
    }
}
