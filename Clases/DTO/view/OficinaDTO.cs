using Data.Models;

namespace Clases.DTO.view
{
    public class OficinaDTO
    {
        public string Idoficina { get; set; }
        public virtual ICollection<FuncionarioDTO> Funcionarios { get; set; }
    }
}
