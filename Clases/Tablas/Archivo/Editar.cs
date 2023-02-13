using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using Data;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Archivo
{
    public class Editar
    {
        public class Ejecuta : IRequest
        {
            public string Idarchivo { get; set; }
            public int? Serieindevep { get; set; }
            public string Delito { get; set; }
            public string Carpeta { get; set; }
            public string Juez { get; set; }
            public string ProcesoPenal { get; set; }
            public string SegundaInstancia { get; set; }
            public string Toca { get; set; }
            public string Amparo { get; set; }
            public string ExpedinteAmparo { get; set; }
            public string Estatus { get; set; }
            public string Fiscalia { get; set; }
            public MateriaLegal materiaLegal { get; set; }
            public string Victima { get; set; }


        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                try
                {
                    var registro = await _unitOfWork.Archivo.GetAsync(request.Idarchivo);
                    
                    if (registro == null)
                        throw new Exception("No se encontró el registro");

                    registro.Serieindevep = request.Serieindevep ?? registro.Serieindevep;
                    registro.Delito = request.Delito ?? registro.Delito;
                    registro.Carpeta = request.Carpeta ?? registro.Carpeta;
                    registro.Juez = request.Juez ?? registro.Juez;
                    registro.ProcesoPenal = request.ProcesoPenal ?? registro.ProcesoPenal;
                    registro.SegundaInstancia = request.SegundaInstancia ?? registro.SegundaInstancia;
                    registro.Toca = request.Toca ?? registro.Toca;
                    registro.Amparo = request.Amparo ?? registro.Amparo;
                    registro.ExpedinteAmparo = request.ExpedinteAmparo ?? registro.ExpedinteAmparo;
                    registro.Victima = request.Victima ?? registro.Victima;
                    registro.Fiscalia = request.Fiscalia ?? registro.Fiscalia;
                    registro.MateriaLegal = request.materiaLegal;
                    _unitOfWork.Archivo.Upadate(registro);
                }
                catch (Exception e)
                {

                    throw new Exception(e.ToString());
                }
                
                


                return RestultadoEF.Salvado(await _unitOfWork.Archivo.SaveAsync());
            }
        }
    }
}
