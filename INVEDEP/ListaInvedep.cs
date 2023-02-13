using Clases.DTO.TableViews;
using INVEDEP.Helpers;
using MediatR;
using System.Reflection;

namespace INVEDEP
{
    public partial class ListaInvedep : Form
    {
        

        IMediator _mediator;
        public ListaInvedep(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }
        private async void ListaInvedep_Load(object sender, EventArgs e)
        {


        }

        private async Task CargarDatosInvedep()
        {
            try
            {
                var datosInvedep = await _mediator.Send(new Clases.Tablas.Peticionario.ListConsulta.Ejecuta()
                {
                    IdFuncionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4"
                });

                DgListadoInvedep.DataSource = datosInvedep;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DgListadoInvedep_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.C)
            {
                UtilidadesGrid.CopiarPortaPaeles(DgListadoInvedep);
                e.Handled = true;
            }
            else if(e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                PropertyInfo[] lst = typeof(CaratulasAlta).GetProperties();
                DgListadoInvedep.DataSource = UtilidadesGrid.PegarPortaPapeles(lst);

                
            }

        }
    }
}
