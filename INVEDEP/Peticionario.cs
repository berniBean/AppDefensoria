﻿using MediatR;


namespace INVEDEP
{
    public partial class Peticionario : Form
    {
        private DatosPersona _datosPersona;
        private string _idArchivo;
        private string _idPeticionario;
        private string _idFiscalia;
        private string _idReportes;
        private string _idParticulares;
        private string _idVictima;

        
        IMediator _mediator;
        private string _idPersona { get; set; }


        public Peticionario(DatosPersona datosPersona, IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
            _datosPersona = datosPersona;
        }

        private void DatosPersonaUpdateEventHandler(object sender, DatosPersona.UpdateEventArgs args)
        {
            CargarDatosParticularesPeticionario();
        }
        private  void Peticionario_Load(object sender, EventArgs e)
        {
            CargarDatosParticularesPeticionario();
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
            _datosPersona.UpdateEventHandler += DatosPersonaUpdateEventHandler;
            _datosPersona.ShowDialog();
        }
        private void BtnFamiliar_Click(object sender, EventArgs e)
        {
            _datosPersona.TipoPersona = "Familiar";
            _datosPersona.IdPeticionario = _idPeticionario;
            _datosPersona.ShowDialog();
        }
        #region ParticularesPeticionarios
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var res = await _mediator.Send(new Clases.Tablas.Peticionario.Editar.Ejecuta()
            {
               IdPeticionario = _idPeticionario,
               Domicilio = tbDirecciones.Text,
               Lengua = tbLengua.Text,
               Telefono = tbTelefono.Text

            });

            var particulares = await _mediator.Send(new Clases.Tablas.Particulares.Editar.Ejecuta()
            {
                IdParticulares = _idParticulares,
                Edad = Convert.ToInt16(tbEdad.Text),
                Ocupacion = tbOcupacion.Text,
                EstadoCivil = tbEstadoCivil.Text,
                Estudios = tbEstudios.Text


            });
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

        private async Task CargarDatosParticularesPeticionario()
        {
            var datosArchivosPeticionario = await _mediator.Send(new Clases.Tablas.Peticionario.ListConsulta.Ejecuta()
            {
                IdFuncionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4"
            }) ;

            DgPeticionarioParticulares.DataSource = datosArchivosPeticionario;
        }


        #endregion

        private void DgPeticionarioParticulares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgPeticionarioParticulares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _idPersona = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[0].Value.ToString();
            _idPeticionario = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[1].Value.ToString();
            _idFiscalia = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[2].Value.ToString();
            _idReportes = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[3].Value.ToString();
            _idParticulares= DgPeticionarioParticulares.Rows[e.RowIndex].Cells[4].Value.ToString();


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
