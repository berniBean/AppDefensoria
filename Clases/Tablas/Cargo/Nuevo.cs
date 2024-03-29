﻿using Clases.ClasesBase;
using Clases.helpers;
using Clases.Repository;
using Data.Models;
using MediatR;

namespace Clases.Tablas.Cargo
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {           
            public string? Puesto { get; set; }
        }

        public class Handler : HandlerOfWork, IRequestHandler<Ejecuta>
        {
            public Handler(IUnitOfWork unitOfWork) : base(unitOfWork)
            {
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var nuevoPuesto = new Data.Models.Cargo
                {
                    Idcargo = Guid.NewGuid().ToString(),
                    Puesto = request.Puesto

                };

                await _unitOfWork.Cargo.AddAsync(nuevoPuesto);

                return RestultadoEF.Salvado(await _unitOfWork.Save());
            }
        }
    }
}
