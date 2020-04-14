using Domain.Base.Entities;
using Domain.Farms.ValueObjects;

namespace Domain.Farms.Entities
{
    public class Farm : AuditableEntity, IFarm
    {
        public string Name { get; set; }
        public PositiveDecimal Area { get; set; }
        public InscricaoEstadual InscricaoEstadual { get; set; }
    }
}
