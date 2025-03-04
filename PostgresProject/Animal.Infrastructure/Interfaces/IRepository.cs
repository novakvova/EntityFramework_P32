namespace Animal.Infrastructure.Interfaces
{
    //Інтерфей вказує на методи, які мають бути в основому класі

    public interface IRepository<T> where T : class
    {
        T? GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
