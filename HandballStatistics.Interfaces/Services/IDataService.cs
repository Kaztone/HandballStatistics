using System.Collections.Generic;
using System.Threading.Tasks;

namespace HandballStatistics.Interfaces.Services
{
    public interface IDataService<T> 
    {
        Task<bool> Init();

        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);

        Task<T> Create(T entity);

        Task<bool> Delete(int id);

        Task<T> Update(int id, T entity);
    }
}
