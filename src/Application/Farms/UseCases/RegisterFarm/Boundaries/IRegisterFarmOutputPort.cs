using Application.Base.Boundaries;
using Application.Farms.Boundaries;

namespace Application.Farms.UseCases.RegisterFarm.Boundaries
{
    public interface IRegisterFarmOutputPort : IOutputPortStandard<FarmUseCaseOutput>
    {
        void FarmAlreadyRegistered(string message);
    }
}
