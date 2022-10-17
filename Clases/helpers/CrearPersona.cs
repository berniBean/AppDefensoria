using Clases.DTO.view;
using MediatR;


namespace Clases.helpers
{
    public static class CrearPersona
    {
        public async static Task<string> NuevaPersona(PersonaDTO persona, IMediator _mediator)
        {
            var IdPesona = await _mediator.Send(new Clases.Tablas.Persona.Nuevo.Ejecuta()
            {
                Nombre = persona.Nombre,
                Apaterno = persona.Apaterno,
                Amaterno = persona.Amaterno
            });

            return IdPesona;
        }

    }
}
