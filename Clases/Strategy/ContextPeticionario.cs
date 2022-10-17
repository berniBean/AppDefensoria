using Clases.DTO.view;
using Clases.Strategy.Intefaces;

namespace Clases.Strategy
{
    public class ContextPeticionario
    {
        private IPersonaStrategy<PersonaDTO> _strategy;
        public IPersonaStrategy<PersonaDTO> Strategy
        {
            get { return _strategy; }
        }
        public ContextPeticionario(IPersonaStrategy<PersonaDTO> strategy)
        {
            _strategy = strategy;
        }

        public async Task Add(PersonaDTO persona)
        {
            await _strategy.Guardar(persona);
        }
    }
}
