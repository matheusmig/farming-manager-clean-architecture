using Application.Base;
using Application.Farms.Boundaries;
using Application.Farms.UseCases.RegisterFarm.Boundaries;
using Domain.Farms;
using Domain.Farms.Entities;
using System.Threading.Tasks;

namespace Application.Farms.UseCases.RegisterFarm
{
    public class RegisterFarmUseCase : IRegisterFarmUseCase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRegisterFarmOutputPort _outputPort;
        private readonly IFarmService _farmService;

        public RegisterFarmUseCase(IUnitOfWork unitOfWork,
            IRegisterFarmOutputPort outputPort,
            IFarmService farmService)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _farmService = farmService;
        }

        public async Task ExecuteAsync(RegisterFarmInput input)
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
            _outputPort.Standard(new FarmUseCaseOutput(
                farm)
            );
        }
    }
}
