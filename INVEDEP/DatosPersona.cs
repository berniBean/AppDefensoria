using MediatR;
using Clases.Tablas.Persona;

namespace INVEDEP
{
    public partial class DatosPersona : Form
    {
        private IMediator _mediator;
        public string IdPesona { get; set; }
        public DatosPersona(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            IdPesona = await _mediator.Send(new Nuevo.Ejecuta()
            {
                Nombre = tbNombre.Text,
                Apaterno = tbApellidoPaterno.Text,
                Amaterno = tbApellidoMaterno.Text
            });
        }

        
    }
}
