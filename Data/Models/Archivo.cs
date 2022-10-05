using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models
{
    public partial class Archivo
    {
        public Archivo()
        {
            Observaciones = new HashSet<Observacione>();
            Victinas = new HashSet<Victina>();
        }

        public string Idarchivo { get; set; }
        public string Delito { get; set; }
        public string Carpeta { get; set; }
        public string Juez { get; set; }
        public string ProcesoPenal { get; set; }
        public string SegundaInstancia { get; set; }
        public string Toca { get; set; }
        public string Amparo { get; set; }
        public string ExpedinteAmparo { get; set; }
        public string PeticionarioIdPeticionario { get; set; }
        public int FiscaliaIdfiscalia { get; set; }
        public string CitasIdcitas { get; set; }
        public int ReportesIdreportes { get; set; }

        public virtual Cita CitasIdcitasNavigation { get; set; }
        public virtual Fiscalium FiscaliaIdfiscaliaNavigation { get; set; }
        public virtual Peticionario PeticionarioIdPeticionarioNavigation { get; set; }
        public virtual Reporte ReportesIdreportesNavigation { get; set; }
        public virtual ICollection<Observacione> Observaciones { get; set; }
        public virtual ICollection<Victina> Victinas { get; set; }
    }
}
