using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.ClasesBase
{
    public class HandlerRequestBase
    {
        public readonly ednita_dbContext _context;
        public HandlerRequestBase(ednita_dbContext context)
        {
            _context = context;
        }
    }
}
