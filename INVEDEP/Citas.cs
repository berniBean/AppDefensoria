

using MediatR;

namespace INVEDEP
{
    public partial class Citas : Form
    {
        private string _idArchivo { get; set; }
        private string _idReporte { get; set; }
        private string _idCita { get; set; }
        private DateTime parsedDate;

        IMediator _mediator;
        public Citas(IMediator mediator)
        {
            
            InitializeComponent();
            _mediator = mediator;
            DtFechaAudiencia.CustomFormat = "dddd, dd MMMM  yyyy  HH:mm";
            DtFechaAudiencia.Format = DateTimePickerFormat.Custom;

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            parsedDate = DtFechaAudiencia.Value;
            if(_idCita is null)
            {
                var res = await _mediator.Send(new Clases.Tablas.Cita.Nuevo.Ejecuta()
                {                    
                                  Sala = TbSala.Text,
                             Audiencia = TbTipoAudiencia.Text,
                        FechaAudiencia = parsedDate,
                    ResultadoAudiencia = txtResultado.Text
                });
            }
            else
            {
                var res = await _mediator.Send(new Clases.Tablas.Cita.Editar.Ejecuta()
                {
                              
                                 Sala = TbSala.Text,
                              Idcitas = _idCita,
                            Audiencia = TbTipoAudiencia.Text,
                       FechaAudiencia = parsedDate,
                   ResultadoAudiencia = txtResultado.Text

                });
            }

            


            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idReporte = DgViewCitas.Rows[e.RowIndex].Cells[1].Value.ToString();
            _idArchivo = DgViewCitas.Rows[e.RowIndex].Cells[2].Value.ToString();
               _idCita = DgViewCitas.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }
        private async void CargarDatosCitas()
        {
            var citas = await _mediator.Send(new Clases.Tablas.Archivo.ListConsulta.Ejecuta()
            {
                IdFuncionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4"
            });
            DgViewCitas.DataSource = citas;
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            CargarDatosCitas();
        }
    }
}
