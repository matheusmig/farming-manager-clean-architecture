using Application.Base.Boundaries;
using Domain.Farms.Entities;

namespace Application.Farms.Boundaries
{
    public class FarmUseCaseOutput : IUseCaseOutput
    {
        public FarmUseCaseOutput(IFarm farm)
        {

            Farm = farm;
        }

        public IFarm Farm { get; }
    }
}
