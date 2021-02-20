using System.Threading.Tasks;

namespace OrderManagement.Core
{
    public interface IDataOperations
    {
        Task Create(object entity);

        Task<object> Get(object entity);

        Task Delete(object entity);

        Task Update(object entity);
    }
}
