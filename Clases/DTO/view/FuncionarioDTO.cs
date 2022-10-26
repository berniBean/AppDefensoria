using Data.Models;

namespace Clases.DTO.view
{
    public class FuncionarioDTO
    {
        public string IdFuncionario { get; set; }
        public string PersonaIdPersona { get; set; }
        public string OficinaIdoficina { get; set; }
        public string CargoIdcargo { get; set; }

        public virtual CargoDTO CargoIdcargoNavigation { get; set; }
        public virtual OficinaDTO OficinaIdoficinaNavigation { get; set; }
        public virtual PersonaDTO PersonaIdPersonaNavigation { get; set; }
        public virtual ICollection<PeticionarioDTO> Peticionarios { get; set; }
    }
}
