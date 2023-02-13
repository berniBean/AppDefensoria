namespace INVEDEP
{
    public partial class Inicio : Form
    {
        private readonly Citas _formCitas;
        private readonly Informes _formInformes;
        private readonly Usuario _formUsuario;
        private readonly Peticionario _formPeticionario;
        private readonly ListaInvedep _listaInvedep;

        public Inicio(Citas formCitas, Informes formInformes, Usuario formUsuario, Peticionario formPeticionario, ListaInvedep listaInvedep)
        {
            InitializeComponent();
            IsMdiContainer = true;
            _formCitas = formCitas;
            _formInformes = formInformes;
            _formUsuario = formUsuario;
            _formPeticionario = formPeticionario;
            _listaInvedep = listaInvedep; 

        }

        private void peticionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formPeticionario.MdiParent = this;
            _formPeticionario.Show();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formCitas.MdiParent = this;
            _formCitas.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formInformes.MdiParent = this;
            _formInformes.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formUsuario.MdiParent = this;
            _formUsuario.Show();
        }

        private void registroInvedepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _listaInvedep.MdiParent = this;
            _listaInvedep.Show();
        }
    }
}
