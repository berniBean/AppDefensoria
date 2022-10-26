namespace Clases.DTO.view
{
    public class ArchivoDTO
    {
        //iD
        public string Idarchivo { get; set; }

        #region Llaves foraneas
        public string IdPeticionario { get; set; }
        public string ParticularesIdParticulares { get; set; }
        #endregion

        public  PeticionarioDTO IdPeticionarioNavigation { get; set; }
        public  ParticularesDto ParticularesIdParticularesNavigation { get; set; }
        public  ICollection<CitaDTO> Cita { get; set; }
    }
}
