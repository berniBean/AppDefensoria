using Data.Models;

namespace Clases.Repository
{
    public interface IUnitOfWork
    {
        public IRepository<Archivo> Archivo { get; }
        public IRepository<Cargo> Cargo { get; }
        public IRepository<Cita> Cita { get; }
        public IRepository<Famiiliar> Familiar { get; }
        public IRepository<Fiscalium> Fiscalia { get; }
        public IRepository<Funcionario> Funcionario { get; }
        public IRepository<Observacione> Observaciones { get; }
        public IRepository<Oficina> Oficina { get; }
        public IRepository<Particulare> Particulares { get; }
        public IRepository<Persona> Persona { get; }
        public IRepository<Peticionario> Peticionario { get; }
        public IRepository<Reporte> Reporte { get; }
        public IRepository<Victina> Victima { get; }

        public Task<int> Save();

    }
}
