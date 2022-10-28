using Clases.helpers;
using Data;
using MediatR;
using System.Runtime.CompilerServices;

namespace INVEDEP
{
    public partial class Peticionario : Form
    {
        private DatosPersona _datosPersona;
        private string _idArchivo;
        private string _idPeticionario;
        private string _idParticulares;

        
        IMediator _mediator;


        public Peticionario(DatosPersona datosPersona, IMediator mediator)
        {
            InitializeComponent();
            _mediator = mediator;
            _datosPersona = datosPersona;
        }

        private async Task DatosPersonaUpdateEventHandler(object sender, DatosPersona.UpdateEventArgs args)
        {
            await CargarDatosParticularesPeticionario();
        }
        private  async void Peticionario_Load(object sender, EventArgs e)
        {
           await CargarDatosParticularesPeticionario();
        }



        private async void BtnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                var res = await _mediator.Send(new Clases.Tablas.Archivo.Editar.Ejecuta()
                {
                    Idarchivo = _idArchivo,
                    Serieindevep = Convert.ToInt16(TbInvedep.Text),
                    Delito = tbDelito.Text,
                    Carpeta = tbCarpeta.Text,
                    Juez = tbJuez.Text,
                    ProcesoPenal = tbProcesoPenal.Text,
                    SegundaInstancia = tbInstancia.Text,
                    Toca = tbToca.Text,
                    Amparo = tbAmparo.Text,
                    ExpedinteAmparo = tbArchivoAmparo.Text,
                    Victima = TbVictima.Text,
                    materiaLegal = (MateriaLegal)CboxMateria.SelectedIndex,
                    Fiscalia = tbFiscalia.Text
                });
            }
            catch (Exception lo)
            {

                throw new Exception(lo.ToString());
            }

            await CargarDatosParticularesPeticionario();
            
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
            _datosPersona.UpdateEventHandler += DatosPersonaUpdateEventHandler;
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
               sexoPeticionario = (SexoPeticionario)CboxSexo.SelectedIndex,
               GrupoEtnico = TbGrupoIndigena.Text,
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

            await CargarDatosParticularesPeticionario();
        }

        #endregion


        private void DgPeticionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        

        #region Funcionalidades


        private async Task CargarDatosParticularesPeticionario()
        {
            try
            {
                var datosArchivosPeticionario = await _mediator.Send(new Clases.Tablas.Peticionario.ListConsulta.Ejecuta()
                {
                    IdFuncionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4"
                });

                DgPeticionarioParticulares.DataSource = datosArchivosPeticionario;
            }
            catch (Exception)
            {

                throw;
            }



        }


        #endregion

        private void DgPeticionarioParticulares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgPeticionarioParticulares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _idArchivo = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[0].Value.ToString();
                _idPeticionario = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[1].Value.ToString();
                _idParticulares = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbEdad.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[3].Value?.ToString();
                tbOcupacion.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[4].Value?.ToString();
                tbEstadoCivil.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[5].Value?.ToString();
                tbEstudios.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[6].Value?.ToString();
                tbLengua.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[7].Value?.ToString();
                tbTelefono.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[8].Value?.ToString();
                tbDirecciones.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[9].Value?.ToString();
                TbInvedep.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[10].Value?.ToString();
                tbDelito.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[11].Value?.ToString();
                tbCarpeta.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[12].Value?.ToString();
                tbJuez.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[13].Value?.ToString();
                tbProcesoPenal.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[14].Value?.ToString();
                tbInstancia.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[15].Value?.ToString();
                tbToca.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[16].Value?.ToString();
                tbAmparo.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[17].Value?.ToString();
                tbArchivoAmparo.Text= DgPeticionarioParticulares.Rows[e.RowIndex].Cells[18].Value?.ToString();
                TbVictima.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[19].Value?.ToString();
                tbFiscalia.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[20].Value?.ToString();
                CboxEstatus.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[27].Value?.ToString();
                CboxMateria.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[28].Value?.ToString();
                CboxSexo.Text = DgPeticionarioParticulares.Rows[e.RowIndex].Cells[29].Value?.ToString();

            }
            catch (Exception)
            {

                throw;
            }





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
