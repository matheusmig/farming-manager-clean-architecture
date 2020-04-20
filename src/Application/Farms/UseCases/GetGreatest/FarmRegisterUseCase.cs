using Application.Base;
using Application.Farms.Boundaries;
using Application.Farms.UseCases.GetGreatest;
using Application.Farms.UseCases.GetGreatest.Boundaries;
using Domain.Farms;
using Domain.Farms.Entities;
using System.Threading.Tasks;

namespace Application.Farms.UseCases.RegisterFarm
{
    public class FarmGetGreatestUseCase : IFarmGetGreatestUseCase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFarmGetGreatestOutputPort _outputPort;
        private readonly IFarmService _farmService;

        public FarmGetGreatestUseCase(IUnitOfWork unitOfWork,
            IFarmGetGreatestOutputPort outputPort,
            IFarmService farmService)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _farmService = farmService;
        }

        public async Task ExecuteAsync()
        {
            var farm = await _farmService.GetGreatestFarm();
            
            BuildOutput(farm);
        }

        private void BuildOutput(IFarm farm)
        {
            _outputPort.Standard(new FarmStandardOutput(
                farm)
            );
        }

        private void BuildNotFound()
        {

        }
    }
}
