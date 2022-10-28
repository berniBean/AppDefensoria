using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Archivo
    {
        public Archivo()
        {
            Cita = new HashSet<Cita>();
        }

        public string Idarchivo { get; set; }
        public int? Serieindevep { get; set; }
        public string Delito { get; set; }
        public string Carpeta { get; set; }
        public string Juez { get; set; }
        public string ProcesoPenal { get; set; }
        public string SegundaInstancia { get; set; }
        public string Toca { get; set; }
        public string Amparo { get; set; }
        public string ExpedinteAmparo { get; set; }
        public MateriaLegal materiaLegal { get; set; }
        public EstatusArchivo Estatus { get; set; }
        public string IdPeticionario { get; set; }
        public string ParticularesIdParticulares { get; set; }
        public string Fiscalia { get; set; }
        public string Victima { get; set; }

        public virtual Peticionario IdPeticionarioNavigation { get; set; }
        public virtual Particulare ParticularesIdParticularesNavigation { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
    }
}
