using MediatR;
using Clases.Tablas.Persona;
using Clases.Strategy;
using Clases.Strategy.Concretas;
using Clases.DTO.view;

namespace INVEDEP
{
    public partial class DatosPersona : Form
    {
        private IMediator _mediator;
        public string? TipoPersona { get; set; }
        public string? IdPeticionario { get; set; }
        public DatosPersona(IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
            
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var Persona =  new PersonaDTO();
            Persona.Nombre = tbNombre.Text;
            Persona.Apaterno = tbApellidoPaterno.Text;
            Persona.Amaterno = tbApellidoMaterno.Text;

            ContextPeticionario context = TipoPersona.Equals("Peticionario") ? 
                new ContextPeticionario(new PeticionarioStrategy(_mediator) { Funcionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4" }) :
                new ContextPeticionario(new FamiliarStrategy(_mediator) { Peticionario = IdPeticionario });

            //var context = new ContextPeticionario(new PeticionarioStrategy(_mediator) 
            //{ Funcionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4" });
            await context.Add(Persona);
            Insert();


        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }

        }
        protected void Insert()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                
            }



        }


    }
}
