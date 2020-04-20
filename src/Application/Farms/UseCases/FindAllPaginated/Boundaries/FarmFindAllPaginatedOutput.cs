using Application.Base.Boundaries;
using Domain.Farms.Entities;
using System.Collections.Generic;

namespace Application.Farms.UseCases.RegisterFarm.Boundaries
{
    public sealed class FarmFindAllPaginatedOutput
    {
        public FarmFindAllPaginatedOutput(long total, IEnumerable<IFarm> farms)
        {
            Total = total;
            Farms = farms;
        }

        public IEnumerable<IFarm> Farms { get; }

        public long Total { get; }
    }
}
