using Clases.ClasesBase;
using Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Clases.Tablas.Funcionario
{
    public class Consulta
    {
        public class Ejecuta : EjecutaRespuestaGen<Data.Models.Funcionario>
        {
            public string? IdFuncionario { get; set; }
        }

        public class Handler : HandlerRequestBase, IRequestHandler<Ejecuta, Data.Models.Funcionario>
        {
            public Handler(ednita_dbContext context) : base(context)
            {
            }

            public async Task<Data.Models.Funcionario> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var funcionario = await _context.Funcionarios.FirstOrDefaultAsync(x => x.Equals(request.IdFuncionario));
                return funcionario;
            }
        }
    }
}
