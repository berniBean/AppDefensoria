using Data;

namespace Clases.DTO.view
{
    public class ArchivoDTO
    {
        //iD
        public string Idarchivo { get; set; }

        #region Llaves foraneas
        public string IdPeticionario { get; set; }
        public string ParticularesIdParticulares { get; set; }

        public int? Serieindevep { get; set; }
        public int? Periodo { get; set; }
        public string Delito { get; set; }
        public string Carpeta { get; set; }
        public string Jurisdiccion { get; set; }
        public string Juez { get; set; }
        public string Distrito { get; set; }
        public string ProcesoPenal { get; set; }
        public string SegundaInstancia { get; set; }
        public string Toca { get; set; }
        public string Amparo { get; set; }
        public string ExpedinteAmparo { get; set; }
        #endregion

        public  PeticionarioDTO IdPeticionarioNavigation { get; set; }
        public  ParticularesDto ParticularesIdParticularesNavigation { get; set; }
        public  ICollection<CitaDTO> Cita { get; set; }
    }
}
