using Clases.DTO.TableViews;
using Clases.DTO.view;
using Clases.Strategy;
using Clases.Strategy.Concretas;
using Data;
using INVEDEP.Helpers;
using INVEDEP.Helpers.ReportProgress;
using MediatR;
using System.Data;
using System.Reflection;

namespace INVEDEP
{
    public partial class ListaInvedep : Form
    {
        

        IMediator _mediator;
        private List<PeticionarioParticularesDGView> Peticionarios;


        public Progress<int> Progreso { get ; set; }

        public ListaInvedep(IMediator mediator )
        {
            InitializeComponent();
            _mediator = mediator;
            
        }
        private async void ListaInvedep_Load(object sender, EventArgs e)
        {

            await CargarDatosInvedep();
        }

        private async Task CargarDatosInvedep()
        {
            new List<PeticionarioParticularesDGView>();
            try
            {
                var datosInvedep = await _mediator.Send(new Clases.Tablas.Peticionario.ListConsulta.Ejecuta()
                {
                    IdFuncionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4"
                });

                Peticionarios = datosInvedep;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void DgListadoInvedep_KeyDown(object sender, KeyEventArgs e)
        {

                if (e.Control && e.KeyCode == Keys.C)
                {
                    UtilidadesGrid.CopiarPortaPaeles(DgListadoInvedep);
                    e.Handled = true;
                }
                else if (e.Control && e.KeyCode == Keys.V)
                {
                    e.Handled = true;
                    PropertyInfo[] lst = typeof(CaratulasAlta).GetProperties();

                    DgListadoInvedep.DataSource = UtilidadesGrid.PegarPortaPapeles(lst).AsEnumerable()
                        .Where(x => x.Field<int?>("Serieindevep") != null).OrderBy(y => y.Field<int?>("Serieindevep")).AsDataView();
                    


                }
            


        }
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var Persona = new PersonaDTO();
            var PeticionarioN = new PeticionarioDTO();
            var Archivo = new ArchivoDTO();
            var pbAnimacion = new ReportBar(PgBarGeneral);
            int indice = 0;

            ContextPeticionario context = new ContextPeticionario(
                new PeticionarioConDatosStrategy(_mediator, PeticionarioN, Archivo)
                { Funcionario = "5df131f7-4bc1-11ed-975f-f4ee08b6e8c4" });


            foreach (DataGridViewRow item in this.DgListadoInvedep.Rows)
            {


                try
                {
                    if (!item.Cells[0].Value.ToString().Equals(null))
                    {
                        Archivo.Serieindevep = Convert.ToInt32(item.Cells[0].Value.ToString());
                        Archivo.Periodo = Convert.ToInt32(item.Cells[1].Value.ToString());


                        Persona.Nombre = item.Cells[2].Value.ToString();
                        Persona.Apaterno = item.Cells[3].Value.ToString();
                        Persona.Amaterno = item.Cells[4].Value.ToString();

                        PeticionarioN.SexoPeticionario = item.Cells[5].Value.ToString().ToUpper().Equals("HOMBRE") ? SexoPeticionario.Hombre : SexoPeticionario.Mujer;

                        Archivo.Delito = item.Cells[6].Value.ToString();
                        Archivo.Carpeta = item.Cells[7].Value.ToString();
                        Archivo.Jurisdiccion = item.Cells[8].Value.ToString();
                        Archivo.Juez = item.Cells[9].Value.ToString();
                        Archivo.ProcesoPenal = item.Cells[10].Value.ToString();
                        Archivo.SegundaInstancia = item.Cells[11].Value.ToString();
                        Archivo.Toca = item.Cells[12].Value.ToString();
                        Archivo.ExpedinteAmparo = item.Cells[13].Value.ToString();
                        PeticionarioN.GrupoEtnico = item.Cells[14].Value.ToString();
                        PeticionarioN.Lengua = item.Cells[15].Value.ToString();
                        PeticionarioN.Domicilio = item.Cells[16].Value.ToString();
                        PeticionarioN.Telefono = item.Cells[17].Value.ToString();


                        indice++;



                        await context.Add(Persona);
                    }

                    pbAnimacion.AvanceProceso(indice, DgListadoInvedep.Rows.Count - 1);
                }

                catch (NullReferenceException)
                {


                }


            }

            MessageBox.Show($"{indice} registros fueron guardados");
            PgBarGeneral.Value = 0;
            this.DgListadoInvedep.DataSource = null;
            this.DgListadoInvedep.Rows.Clear();
        }


        private void DgListadoInvedep_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var colIndex = DgListadoInvedep.CurrentCell.ColumnIndex;
            var colName = DgListadoInvedep.Columns[colIndex].Name;
            if(colName == "Nombre")
            {
                TextBox texbox = (TextBox)e.Control;
                texbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                texbox.AutoCompleteCustomSource = GetSuggestName("Nombre");
                texbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

            if (colName == "Apaterno")
            {
                TextBox texbox = (TextBox)e.Control;
                texbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                texbox.AutoCompleteCustomSource = GetSuggestName("Apaterno");
                texbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

            if (colName == "Amaterno")
            {
                TextBox texbox = (TextBox)e.Control;
                texbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                texbox.AutoCompleteCustomSource = GetSuggestName("Amaterno");
                texbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            if(colName == "Delito")
            {
                TextBox texbox = (TextBox)e.Control;
                texbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                texbox.AutoCompleteCustomSource = GetSuggestName("Delito");
                texbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private AutoCompleteStringCollection GetSuggestName(string Columna)
        {
            
            var query = Peticionarios.Select(element => new
            {
                element.Nombre,
                element.Amaterno,
                element.Apaterno,
                element.Delito

            }).Distinct();



            string[] s = Columna.Equals("Nombre") ?
                query.Select(p => p.Nombre).ToArray() :
                Columna.Equals("Apaterno") ? query.Select(p => p.Apaterno).ToArray() :
                Columna.Equals("Amaterno") ? query.Select(p => p.Amaterno).ToArray() :
                query.Select(p => p.Delito).ToArray();



            AutoCompleteStringCollection collection =  new AutoCompleteStringCollection();
            collection.AddRange(s);
            return collection;
        }


    }
}
