﻿using Data.Models;

namespace Clases.DTO.view
{
    public class PersonaDTO
    {

        public string IdPersona { get; set; }
        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Nombre { get; set; }
        public virtual ICollection<FamiliarDTO> Famiiliars { get; set; }
        public virtual ICollection<FuncionarioDTO> Funcionarios { get; set; }
        public virtual ICollection<PeticionarioDTO> Peticionarios { get; set; }
    }
}
