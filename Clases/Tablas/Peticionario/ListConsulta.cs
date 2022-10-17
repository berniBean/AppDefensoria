using AutoMapper;
using Clases.ClasesBase;
using Clases.DTO.TableViews;
using Clases.Repository;
using MediatR;
using System.Collections.Generic;

namespace Clases.Tablas.Peticionario
{
    public class ListConsulta
    {
        public class Ejecuta : IRequest<List<PeticionarioDGView>>
        {
            public string? IdFuncionario { get; set; }
        }
        public class Handler : HandlerMapperOfWork, IRequestHandler<Ejecuta, List<PeticionarioDGView>>
        {
            public Handler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
            {
            }

            public async Task<List<PeticionarioDGView>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var peticionario = await _unitOfWork.Peticionario.GetASync();

                if (peticionario == null)
                    throw new Exception("no hay registros");

                var filtoPeticionario= peticionario.Where(x => x.FuncionarioIdFuncionario.Equals(request.IdFuncionario)).ToList();

                var mapper = _mapper.Map<List<Data.Models.Peticionario>, List<PeticionarioDGView>>(filtoPeticionario);

                return mapper.ToList();

            }
        }
    }
}
