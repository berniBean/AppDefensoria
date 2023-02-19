namespace INVEDEP.Helpers
{
    public abstract class AbstractProgress
    {
        public Progress<int> reportarProgreso;

        public AbstractProgress()
        {
            reportarProgreso = new Progress<int>(ReportarProgreso);
        }

        public abstract void ReportarProgreso(int porcentaje);
    }
}
