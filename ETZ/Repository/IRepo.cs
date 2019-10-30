using System.Linq;

namespace ETZ.Repository
{
    public interface IRepo<T>
    {
        IQueryable<T> GetAll();
        T GetSpecific(int Id);

        bool Create(T entity);

        bool Update(int key, T entity);

        bool Delete(int key);
    }
}
