using Domain.Farms.Entities;
using Domain.Farms.ValueObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Farms
{
    public interface IFarmService
    {
        Task<IFarm> GetGreatestFarm();

        Task<IFarm> RegisterFarmAsync(string name, PositiveDecimal area, InscricaoEstadual inscricaoEstadual);
        Task<bool> IsRegisteredAsync(string farmName);

        Task<IEnumerable<IFarm>> FindAllPaginatedAsync(int top, int skip);
        Task<long> CountAllAsync();
    }
}
