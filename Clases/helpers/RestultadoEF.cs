using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.helpers
{
    public static class RestultadoEF
    {
        public static Unit Salvado(int respuesta)
        {
            if (respuesta > 0)
                return Unit.Value;
            else
                throw new Exception("No se pudo actualizar el registro");

        }
    }
}
