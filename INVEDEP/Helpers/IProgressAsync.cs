using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INVEDEP.Helpers
{
    public interface IProgressAsync
    {
        Progress<int> Progreso { get; set; }
        void ReportarProgreso(int porcentaje);
    }
}
