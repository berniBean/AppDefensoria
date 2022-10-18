using Clases.DTO.view;
using Clases.Strategy.Intefaces;
using MediatR;

namespace Clases.Strategy.Concretas
{
    public class FiscaliaStrategy : IGuardarStrategy<FiscaliaDTO>
    {
        public string? Fiscalia { get; set; }
        private IMediator _mediator;

        public FiscaliaStrategy(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Guardar(FiscaliaDTO persona)
        {
            try
            {
                
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
