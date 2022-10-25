namespace Clases.DTO.TableViews
{
    public class CitasDGView 
    {
        public string Idarchivo { get; set; }
        public string IdPeticionario { get; set; }
        public string ParticularesIdParticulares { get; set; }

        //Archivo
        public int? Serieindevep { get; set; }
        public string Delito { get; set; }
        public string Carpeta { get; set; }
        public string Juez { get; set; }
        public string ProcesoPenal { get; set; }
        public string SegundaInstancia { get; set; }
        public string Toca { get; set; }
        public string Amparo { get; set; }
        public string ExpedinteAmparo { get; set; }
        public string Estatus { get; set; }
        public string Fiscalia { get; set; }
        public string Victima { get; set; }

        //Peticionario
        public string Domicilio { get; set; }
        public string Lengua { get; set; }
        public string Telefono { get; set; }

        //Particulares
        public int? Edad { get; set; }
        public string Ocupacion { get; set; }
        public string EstadoCivil { get; set; }
        public string Estudios { get; set; }


        public string Apaterno { get; set; }
        public string Amaterno { get; set; }
        public string Nombre { get; set; }


    }
}
