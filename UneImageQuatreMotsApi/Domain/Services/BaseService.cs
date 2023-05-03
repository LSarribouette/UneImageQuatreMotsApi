using UneImageQuatreMotsApi.Domain.Interfaces;

namespace UneImageQuatreMotsApi.Domain.Services
{
    public class BaseService<T> : IService<T> where T : class
    {
        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> FetchAll()
        {
            throw new NotImplementedException();
        }

        public T FindBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
