using Domain.Farms.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Farms
{
    public interface IFarmRepository
    {
        Task<IFarm> GetByAsync(long id);
        Task<IFarm> GetByAsync(string name);
        Task<IFarm> GetGreatestAsync();
        Task<IEnumerable<IFarm>> FindAllPaginatedAsync(int top, int skip);
        Task<long> CountAllAsync();
        Task AddAsync(IFarm farm);
        Task UpdateAsync(IFarm farm);
    }
}
