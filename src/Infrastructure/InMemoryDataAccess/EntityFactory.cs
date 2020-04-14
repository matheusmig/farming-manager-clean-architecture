using Domain.Farms;
using Domain.Farms.Entities;
using Domain.Farms.ValueObjects;

namespace Infrastructure.InMemoryDataAccess
{
    public sealed class EntityFactory : IFarmFactory
    {
        public IFarm NewFarm(string name, PositiveDecimal area, InscricaoEstadual inscricaoEstadual) =>
            new Entities.Farm(name, area, inscricaoEstadual);
    }
}
