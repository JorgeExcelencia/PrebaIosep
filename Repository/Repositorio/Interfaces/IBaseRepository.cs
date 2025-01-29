namespace ApiIosep.Repositorio.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {

        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(object id);
        Task Insert(T obj);
        Task Update(T obj);
        Task Delete(object id);
        Task Save();

    }
}
