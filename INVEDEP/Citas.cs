using Clases.DTO.view;
using MediatR;

namespace INVEDEP
{
    public partial class Citas : Form
    {
        private string _idArchivo { get; set; }
        private DateTime parsedDate;

        IMediator _mediator;
        public Citas(IMediator mediator)
        {
            
            InitializeComponent();
            _mediator = mediator;
            DtFechaAudiencia.CustomFormat = "dddd, dd MMMM  yyyy  HH:mm";
            DtFechaAudiencia.Format = DateTimePickerFormat.Custom;

        }
        private async void BtnNuevacita_Click(object sender, EventArgs e)
        {
            parsedDate = DtFechaAudiencia.Value;

                var res = await _mediator.Send(new Clases.Tablas.Cita.Nuevo.Ejecuta()
                {
                    IdArchivo = _idArchivo,
                    Sala = TbSala.Text,
                    Audiencia = TbTipoAudiencia.Text,
                    TipoAtencion = (Data.TipoAtencion)CboxTipoAsistencia.SelectedIndex,
                    FechaAudiencia = parsedDate,
                    ResultadoAudiencia = txtResultado.Text

                });
            
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            parsedDate = DtFechaAudiencia.Value;
            CitaDTO? cita = await _mediator.Send(new Clases.Tablas.Cita.Consulta.Ejecuta()
            {
                IdArchivo = _idArchivo
            });

                var res = await _mediator.Send(new Clases.Tablas.Cita.Editar.Ejecuta()
                {

                    Sala = TbSala.Text,
                    Idcitas = cita.Idcitas,
                    Audiencia = TbTipoAudiencia.Text,
                    TipoAtencion = (Data.TipoAtencion)CboxTipoAsistencia.SelectedIndex,
                    FechaAudiencia = parsedDate,
                    ResultadoAudiencia = txtResultado.Text

                });

            await CargarRegistrosAudiencias(cita.Idcitas);




        }

        private async  void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idArchivo = DgViewCitas.Rows[e.RowIndex].Cells[0].Value.ToString();

            await CargarRegistrosAudiencias(DgViewCitas.Rows[e.RowIndex].Cells[0].Value.ToString());

        }
        private async Task CargarDatosCitas()
        {
            var citas = await _mediator.Send(new Clases.Tablas.Archivo.ListConsulta.Ejecuta()
            {
                IdFuncionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4"
            });
            DgViewCitas.DataSource = citas;
        }

        private async Task CargarRegistrosAudiencias(string id)
        {
            var registros = await _mediator.Send(new Clases.Tablas.Cita.ListCitas.Ejecuta()
            {
                IdFuncionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4",
                IdArchivo = id
            });
            DgRegistroAudiencia.DataSource = registros;
        }
        
        private  async void Citas_Load(object sender, EventArgs e)
        {
                await CargarDatosCitas();
                
            
            
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

        private void DgRegistroAudiencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TbSala.Text = DgRegistroAudiencia.Rows[e.RowIndex].Cells[1].Value?.ToString();
            TbTipoAudiencia.Text = DgRegistroAudiencia.Rows[e.RowIndex].Cells[2].Value?.ToString();
            txtResultado.Text = DgRegistroAudiencia.Rows[e.RowIndex].Cells[5].Value?.ToString();
        }
    }
}
