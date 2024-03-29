﻿using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using MediatR;

namespace Clases.Tablas.Cargo
{
    public class Eliminar
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

                await _unitOfWork.Cargo.DeleteAsync(registro.Idcargo);
               

                return RestultadoEF.Salvado(await _unitOfWork.Cargo.SaveAsync());
            }
        }
    }
}
