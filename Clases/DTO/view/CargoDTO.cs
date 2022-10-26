using Data.Models;

namespace Clases.DTO.view
{
    public class CargoDTO
    {
        public string Idcargo { get; set; }
        //Datos
        public virtual ICollection<FuncionarioDTO> Funcionarios { get; set; }
    }
}
