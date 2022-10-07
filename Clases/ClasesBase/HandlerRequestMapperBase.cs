using AutoMapper;
using Data.Models;

namespace Clases.ClasesBase
{
    public class HandlerRequestMapperBase
    {
        public readonly ednita_dbContext _context;
        public readonly IMapper _mapper;
        public HandlerRequestMapperBase(ednita_dbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
