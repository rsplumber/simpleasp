using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication.Domain.Base
{
    public interface IBaseRepository<Entity , Id>
    {
        
        Task<Entity> CreateAsync(Entity model);
        
        Task<bool> DeleteAsync(Entity model);
        
        Task<List<Entity>> Get();
        
        Task<Entity> UpdateAsync(Entity model);
        
        Task<Entity> FindById(Id id);
        
    }
}