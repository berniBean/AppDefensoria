using Clases.Repository;

namespace Clases.ClasesBase
{
    public class HandlerOfWork
    {
        public readonly IUnitOfWork _unitOfWork;
        public HandlerOfWork(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
