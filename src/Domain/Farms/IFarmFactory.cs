using Domain.Farms.Entities;
using Domain.Farms.ValueObjects;

namespace Domain.Farms
{
    public interface IFarmFactory
    {
        IFarm NewFarm(string name, PositiveDecimal area, InscricaoEstadual inscricaoEstadual);
    }
}
