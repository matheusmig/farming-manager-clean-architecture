using Application.Base.Boundaries;
using Domain.Farms.Entities;

namespace Application.Farms.Boundaries
{
    public class FarmStandardOutput
    {
        public FarmStandardOutput(IFarm farm)
        {

            Farm = farm;
        }

        public IFarm Farm { get; }
    }
}
