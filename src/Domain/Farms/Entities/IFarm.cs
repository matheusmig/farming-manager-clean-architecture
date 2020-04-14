using Domain.Base.Entities;
using Domain.Farms.ValueObjects;

namespace Domain.Farms.Entities
{
    public interface IFarm : IAuditableEntity
    {
        string Name { get; set; }
        PositiveDecimal Area { get; set; }
        InscricaoEstadual InscricaoEstadual { get; set; }
    }
}
