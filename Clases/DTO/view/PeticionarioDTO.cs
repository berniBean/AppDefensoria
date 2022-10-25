using Data.Models;

namespace Clases.DTO.view
{
    public class PeticionarioDTO
    {
        public string IdPeticionario { get; set; }
        public string Alias { get; set; }
        public string IdentidadResguardada { get; set; }
        public string Domicilio { get; set; }
        public string GrupoEtnico { get; set; }
        public string Lengua { get; set; }
        public string Telefono { get; set; }
        public string PersonaIdPersona { get; set; }
        public string FuncionarioIdFuncionario { get; set; }

        public virtual ICollection<Archivo> Archivos { get; set; }
    }
}
