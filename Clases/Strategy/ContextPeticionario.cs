using Clases.DTO.view;
using Clases.Strategy.Intefaces;

namespace Clases.Strategy
{
    public class ContextPeticionario
    {
        private IGuardarStrategy<PersonaDTO> _strategy;
        public IGuardarStrategy<PersonaDTO> Strategy
        {
            get { return _strategy; }
        }
        public ContextPeticionario(IGuardarStrategy<PersonaDTO> strategy)
        {
            _strategy = strategy;
        }

        public async Task Add(PersonaDTO persona)
        {
            await _strategy.Guardar(persona);
        }
    }
}
