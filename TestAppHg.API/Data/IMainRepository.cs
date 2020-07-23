using System.Threading.Tasks;
using TestAppHg.API.Models;

namespace TestAppHg.API.Data
{
    public interface IMainRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();

        Task<Value> GetValue(int id);
    }


}