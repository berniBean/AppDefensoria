using MediatR;
using Clases.Tablas.Archivo;

namespace INVEDEP
{
    public partial class Peticionario : Form
    {
        private DatosPersona _datosPersona;
        IMediator _mediator;
        private string _idPersona { get; set; }
        private string _idPeticionario { get; set; }


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



        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception lo)
            {

                throw new Exception(lo.ToString());
            }

            
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoPeticionario_Click(object sender, EventArgs e)
        {
            _datosPersona.TipoPersona = "Peticionario";
            _datosPersona.Show();
            


        }
        #region ParticularesPeticionarios
        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            var res = await _mediator.Send(new Clases.Tablas.Peticionario.Nuevo.Ejecuta()
            {
                Domicilio = tbDirecciones.Text,                
                Lengua = tbLengua.Text,
                Telefono = tbTelefono.Text,
                PersonaIdPersona = _idPersona,
                FuncionarioIdFuncionario = "95735ce7-ed42-4f40-afbc-99c688abf123"
            });
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void DgPeticionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        

        #region Funcionalidades
        private async void CargarTablaPeticionarios()
        {
            var listado = await _mediator.Send(new Clases.Tablas.Peticionario.ListConsulta.Ejecuta()
            {
                IdFuncionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4"
            });

            DgPeticionarioParticulares.DataSource = listado;
           
        }

        private async void CargarDatosParticularesPeticionario()
        {
            //var datoParticular = await _mediator.Send(new Clases.Tablas.)
        }


        #endregion

        private void DgPeticionarioParticulares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgPeticionarioParticulares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idPersona = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[0].Value.ToString();

           
        }


    }
}
