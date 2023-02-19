using Clases.DTO.view;
using Clases.Strategy.Intefaces;
using MediatR;

namespace Clases.Strategy.Concretas
{
    public class PeticionarioConDatosStrategy : IGuardarStrategy<PersonaDTO>
    {
        public string? Funcionario { get; set; }

        private IMediator _mediator;
        private PeticionarioDTO _peticionarioDTO { get; set; }
        private ArchivoDTO _archivoDTO { get; set; }

        public PeticionarioConDatosStrategy(IMediator mediator, PeticionarioDTO peticionario, ArchivoDTO archivo)
        {
            _mediator = mediator;
            _peticionarioDTO = peticionario;
            _archivoDTO = archivo;
        }

        public async Task Guardar(PersonaDTO persona)
        {
            var IdPersona = await helpers.CrearPersona.NuevaPersona(persona, _mediator);

            var Idpeticionario = await _mediator.Send(new Clases.Tablas.Peticionario.Nuevo.Ejecuta()
            {
                PersonaIdPersona = IdPersona,
                FuncionarioIdFuncionario = Funcionario,
                Domicilio = _peticionarioDTO.Domicilio,
                GrupoEtnico = _peticionarioDTO.GrupoEtnico,
                Lengua = _peticionarioDTO.Lengua,
                Telefono = _peticionarioDTO.Telefono


            });


            var IdParticulares = await helpers.CrearParticulares.NuevoPartculares(Idpeticionario, _mediator);

            var archivo = await _mediator.Send(new Clases.Tablas.Archivo.Nuevo.Ejecuta()
            {
                IdPeticionario = Idpeticionario,
                ParticularesIdParticulares = IdParticulares,

                Serieindevep = _archivoDTO.Serieindevep,
                Periodo = _archivoDTO.Periodo,
                Delito = _archivoDTO.Delito,
                Carpeta = _archivoDTO.Carpeta,
                Jurisdiccion = _archivoDTO.Jurisdiccion,
                Juez = _archivoDTO.Juez,
                Distrito = _archivoDTO.Distrito,
                ProcesoPenal = _archivoDTO.ProcesoPenal,
                SegundaInstancia = _archivoDTO.SegundaInstancia,
                Toca = _archivoDTO.Toca,
                Amparo = _archivoDTO.Amparo,
                ExpedinteAmparo = _archivoDTO.ExpedinteAmparo


            });
        }
    }
}
