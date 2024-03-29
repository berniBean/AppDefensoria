﻿using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Cargo
{
    public class Editar 
    {
        public class Ejecuta : IRequest
        {
            public string? Idcargo { get; set; }
            public string? Puesto { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var registro = await _unitOfWork.Cargo.GetAsync(request.Idcargo);

                if (registro == null)
                    throw new Exception("No se encontró el Cargo");

                registro.Puesto = request.Puesto ?? registro.Puesto;

                _unitOfWork.Cargo.Upadate(registro);

                return RestultadoEF.Salvado(await _unitOfWork.Cargo.SaveAsync());
                
            }
        }
    }
}
