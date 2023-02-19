using Data;
using Data.Models;

namespace Clases.DTO.view
{
    public class PeticionarioDTO
    {
        public string IdPeticionario { get; set; }

        public string PersonaIdPersona { get; set; }
        public string FuncionarioIdFuncionario { get; set; }
        public string Domicilio { get; set; }
        public string GrupoEtnico { get; set; }
        public string Lengua { get; set; }
        public string Telefono { get; set; }
        public SexoPeticionario SexoPeticionario { get; set; }
        public virtual FuncionarioDTO FuncionarioIdFuncionarioNavigation { get; set; }
        public virtual PersonaDTO PersonaIdPersonaNavigation { get; set; }
        public virtual ICollection<ArchivoDTO> Archivos { get; set; }
        public virtual ICollection<FamiliarDTO> Famiiliars { get; set; }
    }
}
