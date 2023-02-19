using Clases.DTO.TableViews;

namespace INVEDEP.Helpers.ReportProgress
{
    public class PeticionariosNuevos : AbstractProgress
    {
        private readonly ToolStripProgressBar _progressBar;

        public async Task CargarListadoDB(IEnumerable<CaratulasAlta> consulta)
        {
            await ProcesoDeCarga(consulta.ToList(), reportarProgreso);
        }

        private async Task ProcesoDeCarga(List<CaratulasAlta> consulta, IProgress<int> progress)
        {
            int indice = 0;
            foreach (var item in consulta)
            {
                if(progress != null)
                {
                    indice++;
                    progress.Report(StaticPercentage.PercentageProgress(indice, consulta.Count));
                }

            }

            MessageBox.Show("Carga Completada");
            progress.Report(0);
        }

        public override void ReportarProgreso(int porcentaje)
        {
            throw new NotImplementedException();
        }
    }
}
