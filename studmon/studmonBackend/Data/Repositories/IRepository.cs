namespace studmonBackend.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> ReadAll();
        T ReadOne(string id);
        void DeleteById(string id);

        void Update(T item);

        void Create(T item);
    }
}
