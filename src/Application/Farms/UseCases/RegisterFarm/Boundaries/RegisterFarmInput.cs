using Application.Base.Boundaries;
using Domain.Farms.ValueObjects;

namespace Application.Farms.UseCases.RegisterFarm.Boundaries
{
    public sealed class RegisterFarmInput : IUseCaseInput
    {
        public RegisterFarmInput(string name, PositiveDecimal area, InscricaoEstadual inscricaoEstadual)
        {
            Name = name;
            Area = area;
            InscricaoEstadual = inscricaoEstadual;
        }

        public string Name { get; }
        public PositiveDecimal Area { get; }
        public InscricaoEstadual InscricaoEstadual { get; }
    }
}
