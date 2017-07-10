using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Interfaces
{
    public interface IGenericRepository<T>
    {
        int Save();
        IList<T> Get();
        T Get(string id);
        Task<IList<T>> GetAsync();
        Task<T> GetAsync(string id);
    }
}