using Domain.Farms.ValueObjects;

namespace Infrastructure.InMemoryDataAccess.Entities
{
    public class Farm : Domain.Farms.Entities.Farm
    {
        public Farm(string name,
            PositiveDecimal area,
            InscricaoEstadual ie)
        {
            Name = name;
            Area = area;
            InscricaoEstadual = ie;
        }

        protected Farm()
        {
        }

    }
}
