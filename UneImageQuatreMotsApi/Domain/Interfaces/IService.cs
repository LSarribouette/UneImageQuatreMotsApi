namespace UneImageQuatreMotsApi.Domain.Interfaces
{
    public interface IService<T> where T : class
    {
        public void Create(T entity);

        public void Delete(T entity);

        public void Edit(T entity);

        public List<T> FetchAll();

        public T FindBy(int id);
    }
}
