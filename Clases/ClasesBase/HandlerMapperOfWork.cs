using AutoMapper;
using Clases.Repository;

namespace Clases.ClasesBase
{
    public class HandlerMapperOfWork
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;

        public HandlerMapperOfWork(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
