using Clases.ClasesBase;
using Data.Models;

namespace Clases.Repository
{
    public class UnitOfWork : HandlerRequestBase, IUnitOfWork
    {

        private IRepository<Archivo>? _archivo;
        private IRepository<Cargo>? _cargo;
        private IRepository<Cita>? _cita;
        private IRepository<Famiiliar>? _familiar;
        private IRepository<Funcionario>? _funcionario;

        private IRepository<Oficina>? _oficina;
        private IRepository<Particulare>? _particulares;
        private IRepository<Persona>? _persona;
        private IRepository<Peticionario>? _peticionario;
        private IRepository<Reporte>? _reporte;

        public UnitOfWork(ednita_dbContext context) : base(context)
        {
        }





        public IRepository<Archivo> Archivo { get { return _archivo == null ? _archivo = new Repository<Archivo>(_context) : _archivo; } }

        public IRepository<Cargo> Cargo { get { return _cargo == null ? _cargo = new Repository<Cargo>(_context) : _cargo; } }

        public IRepository<Cita> Cita { get { return _cita == null ? _cita = new Repository<Cita>(_context) : _cita; } }

        public IRepository<Famiiliar> Familiar { get { return _familiar == null ? _familiar = new Repository<Famiiliar>(_context) : _familiar; } }


        public IRepository<Funcionario> Funcionario { get { return _funcionario == null ? _funcionario = new Repository<Funcionario>(_context) : _funcionario; } }



        public IRepository<Oficina> Oficina { get { return _oficina == null ? _oficina = new Repository<Oficina>(_context) : _oficina; } }

        public IRepository<Particulare> Particulares { get { return _particulares == null ? _particulares = new Repository<Particulare>(_context) : _particulares; } }

        public IRepository<Reporte> Reporte { get { return _reporte == null ? _reporte = new Repository<Reporte>(_context) : _reporte; } }


        public IRepository<Persona> Persona { get { return _persona == null ? _persona = new Repository<Persona>(_context) : _persona; } }

        public IRepository<Peticionario> Peticionario { get { return _peticionario == null ? _peticionario = new Repository<Peticionario>(_context) : _peticionario; } }

        public async Task<int> Save()
        {
           return await _context.SaveChangesAsync();
        }
    }
}
