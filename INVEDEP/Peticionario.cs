using MediatR;
using Clases.Tablas.Archivo;

namespace INVEDEP
{
    public partial class Peticionario : Form
    {
        private DatosPersona _datosPersona;
        IMediator _mediator;
        private string _idPersona { get; set; }

        public Peticionario(DatosPersona datosPersona, IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
            _datosPersona = datosPersona;
        }
        private  void Peticionario_Load(object sender, EventArgs e)
        {
            CargarTablaPeticionarios();
        }

        private async void CargarTablaPeticionarios()
        {
            var listado = await _mediator.Send(new Clases.Tablas.Peticionario.ListConsulta.Ejecuta()
            {
                IdFuncionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4"
            });

            DgPeticionarioParticulares.DataSource = listado;
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
           
            
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            var res = _mediator.Send(new Nuevo.Ejecuta()
            {
                Serieindevep =  Convert.ToInt32(TbInvedep.Text),
                Delito = tbDelito.Text,
                Carpeta = tbCarpeta.Text,
                Juez = tbJuez.Text,
                ProcesoPenal = tbProcesoPenal.Text,
                Toca = tbToca.Text,
                Amparo = tbAmparo.Text,
                ExpedinteAmparo = tbArchivoAmparo.Text
                
                
            }) ;
        }

        private void btnNuevoPeticionario_Click(object sender, EventArgs e)
        {
            _datosPersona.TipoPersona = "Peticionario";
            _datosPersona.Show();
            


        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
           
            var res = await _mediator.Send(new Clases.Tablas.Peticionario.Nuevo.Ejecuta()
            {
                Domicilio = tbDirecciones.Text,
                GrupoEtnico = tbGrupoEtnico.Text,
                Lengua = tbLengua.Text,
                Telefono = tbTelefono.Text,
                PersonaIdPersona = _idPersona,
                FuncionarioIdFuncionario = "95735ce7-ed42-4f40-afbc-99c688abf123"
            });
        }


    }
}
