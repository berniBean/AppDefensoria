using Data.Models;

namespace Clases.DTO.view
{
    public class FamiliarDTO
    {
        public string PersonaIdPersona { get; set; }
        public string PeticionarioIdPeticionario { get; set; }
        public  PersonaDTO PersonaIdPersonaNavigation { get; set; }
        public  PeticionarioDTO PeticionarioIdPeticionarioNavigation { get; set; }
    }
}
