using Clases.DTO.TableViews;
using Clases.DTO.view;
using Clases.Strategy;
using Clases.Strategy.Concretas;
using INVEDEP.Helpers;
using MediatR;
using System.Reflection;

namespace INVEDEP
{
    public partial class ListaInvedep : Form
    {
        

        IMediator _mediator;
        private List<CaratulasAlta> ListadoCaratulas;
        public ListaInvedep(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }
        private async void ListaInvedep_Load(object sender, EventArgs e)
        {
            ListadoCaratulas = new List<CaratulasAlta>();

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

        private async void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Persona = new PersonaDTO();

            foreach (DataGridViewRow item in this.DgListadoInvedep.Rows)
            {
                try
                {
                    if (!item.Cells[0].Value.ToString().Equals(null))
                    {
                        Persona.Nombre = item.Cells[2].Value.ToString();
                        Persona.Apaterno = item.Cells[3].Value.ToString();
                        Persona.Amaterno = item.Cells[4].Value.ToString();

                        ContextPeticionario context = new ContextPeticionario(new PeticionarioStrategy(_mediator) { Funcionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4" });

                        await context.Add(Persona);
                    }
                }
                catch (NullReferenceException)
                {

                    
                }


            }
        }
    }
}
