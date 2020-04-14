using Application.Base.Boundaries;
using Domain.Farms.ValueObjects;

namespace Application.Farms.UseCases.RegisterFarm.Boundaries
{
    public sealed class FarmFindAllPaginatedInput : IUseCaseInput
    {
        public FarmFindAllPaginatedInput(int top, int skip)
        {
            Top = top;
            Skip = skip;
        }

        public int Top { get; }
        public int Skip { get; }
    }
}
