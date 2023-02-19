namespace INVEDEP.Helpers.ReportProgress
{
    public class ReportBar : AbstractProgress
    {
        private readonly ToolStripProgressBar _progressBar;
        public ReportBar(ToolStripProgressBar progressBar)
        {
            _progressBar = progressBar;
        }


        public void AvanceProceso(int consulta,int totalElementos)
        {
            CalcualarAvance(consulta, totalElementos, reportarProgreso);
        }

        private static void CalcualarAvance(int consulta,int totalElementos, IProgress<int> progress)
        {
            if (progress != null)
            {
                progress.Report(StaticPercentage.PercentageProgress(consulta, totalElementos));
            }

            

        }

        public override void ReportarProgreso(int porcentaje)
        {
            _progressBar.Value = porcentaje;
        }
    }
}
