using Domain.Farms;
using Domain.Farms.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.InMemoryDataAccess.Repositories
{
    public class FarmRepository : IFarmRepository
    {
        private readonly CleanArchContext _context;

        public FarmRepository(CleanArchContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task AddAsync(IFarm farm)
        {
            _context.Farms.Add((Entities.Farm)farm);
            await Task.CompletedTask
               .ConfigureAwait(false);
        }

        public async Task<IFarm> GetByAsync(long id)
        {
            var farm = _context.Farms
                .Where(c => c.Id.Equals(id))
                .SingleOrDefault();

            return await Task.FromResult(farm)
                .ConfigureAwait(false);
        }

        public async Task<IFarm> GetByAsync(string name)
        {
            var farm = _context.Farms
                .Where(c => c.Name.Equals(name))
                .SingleOrDefault();

            return await Task.FromResult(farm)
                .ConfigureAwait(false);
        }

        public async Task<IEnumerable<IFarm>> FindAllPaginatedAsync(int top, int skip)
        {
            var farms = _context.Farms
                .Skip(skip)
                .Take(top);

            return await Task.FromResult(farms)
              .ConfigureAwait(false);
        }

        public async Task<long> CountAllAsync()
        {
            var count = _context.Farms
               .Count();

            return await Task.FromResult(count)
                .ConfigureAwait(false);
        }

        public async Task UpdateAsync(IFarm farm)
        {
            var farmOld = _context.Farms
                  .Where(e => e.Id.Equals(farm.Id))
                  .SingleOrDefault();

            farmOld = (Entities.Farm)farm;

            await Task.CompletedTask
                .ConfigureAwait(false);
        }
    }
}
