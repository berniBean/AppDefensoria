using Data.Models;

namespace Clases.DTO.view
{
    public class PeticionarioDTO
    {
        public string IdPeticionario { get; set; }

        public string PersonaIdPersona { get; set; }
        public string FuncionarioIdFuncionario { get; set; }

        public virtual FuncionarioDTO FuncionarioIdFuncionarioNavigation { get; set; }
        public virtual PersonaDTO PersonaIdPersonaNavigation { get; set; }
        public virtual ICollection<ArchivoDTO> Archivos { get; set; }
        public virtual ICollection<FamiliarDTO> Famiiliars { get; set; }
    }
}
