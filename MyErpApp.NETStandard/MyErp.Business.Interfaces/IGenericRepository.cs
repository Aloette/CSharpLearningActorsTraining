namespace MyErp.Business.Interfaces
{
    public interface IGenericRepository<T>
    {
        void Create(T entity);
        IEnumerable<T> GetAll();
    }
}
