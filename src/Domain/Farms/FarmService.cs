using Domain.Farms.Entities;
using Domain.Farms.ValueObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Farms
{
    public class FarmService : IFarmService
    {
        private readonly IFarmFactory _farmFactory;
        private readonly IFarmRepository _farmRepository;

        public FarmService(IFarmFactory farmFactory,
            IFarmRepository farmRepository)
        {
            _farmFactory = farmFactory;
            _farmRepository = farmRepository;
        }

        public async Task<IFarm> GetGreatestFarm()
        {
            return await _farmRepository.GetGreatestAsync();
        }

        public async Task<IFarm> RegisterFarmAsync(string name, PositiveDecimal area, InscricaoEstadual inscricaoEstadual)
        {
            var newFarm = _farmFactory.NewFarm(name, area, inscricaoEstadual);
            await _farmRepository.AddAsync(newFarm);
            return newFarm;
        }

        public async Task<bool> IsRegisteredAsync(string farmName)
        {
            var foundFarm = await _farmRepository.GetByAsync(farmName);
            if (foundFarm == null)    
                return false;

            return true;
        }

        public async Task<IEnumerable<IFarm>> FindAllPaginatedAsync(int top, int skip)
        {
            return await _farmRepository.FindAllPaginatedAsync(top, skip);
        }

        public async Task<long> CountAllAsync()
        {
            return await _farmRepository.CountAllAsync();
        }
    }
}
