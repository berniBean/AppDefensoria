namespace Clases.Strategy.Intefaces
{
    public interface IGuardarStrategy<T> where T : class
    {
        public Task Guardar(T persona);
    }
}
