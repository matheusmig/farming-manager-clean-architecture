using Application.Base;
using Application.Farms.Boundaries;
using Application.Farms.UseCases.RegisterFarm.Boundaries;
using Domain.Farms;
using Domain.Farms.Entities;
using System.Threading.Tasks;

namespace Application.Farms.UseCases.RegisterFarm
{
    public class FarmRegisterUseCase : IFarmRegisterUseCase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFarmRegisterOutputPort _outputPort;
        private readonly IFarmService _farmService;

        public FarmRegisterUseCase(IUnitOfWork unitOfWork,
            IFarmRegisterOutputPort outputPort,
            IFarmService farmService)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _farmService = farmService;
        }

        public async Task ExecuteAsync(FarmRegisterInput input)
        {
            if (await _farmService.IsRegisteredAsync(input.Name))
            {
                { 
                    _outputPort.FarmAlreadyRegistered($"Farm {input.Name} already exists");
                    return;
                }
            }

            var farm = await _farmService.RegisterFarmAsync(input.Name, input.Area, input.InscricaoEstadual);

            await _unitOfWork.SaveAsync();

            BuildOutput(farm);
        }

        private void BuildOutput(IFarm farm)
        {
            _outputPort.Standard(new FarmStandardOutput(
                farm)
            );
        }
    }
}
