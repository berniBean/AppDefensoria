namespace Clases.Strategy.Intefaces
{
    public interface IPersonaStrategy<T> where T : class
    {
        public Task Guardar(T persona);
    }
}
