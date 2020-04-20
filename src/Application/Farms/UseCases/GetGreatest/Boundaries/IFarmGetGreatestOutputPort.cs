using Application.Base.Boundaries;
using Application.Farms.Boundaries;

namespace Application.Farms.UseCases.GetGreatest.Boundaries
{
    public interface IFarmGetGreatestOutputPort : IOutputPortStandard<FarmStandardOutput>
    {
        void FarmNotFound(string message);
    }
}
