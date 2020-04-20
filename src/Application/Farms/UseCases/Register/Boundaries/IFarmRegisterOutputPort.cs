using Application.Base.Boundaries;
using Application.Farms.Boundaries;

namespace Application.Farms.UseCases.RegisterFarm.Boundaries
{
    public interface IFarmRegisterOutputPort : IOutputPortStandard<FarmStandardOutput>
    {
        void FarmAlreadyRegistered(string message);
    }
}
