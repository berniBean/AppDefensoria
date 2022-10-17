using Data.Models;

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
