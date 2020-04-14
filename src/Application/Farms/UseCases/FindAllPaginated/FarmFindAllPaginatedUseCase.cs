using Application.Base;
using Application.Farms.UseCases.RegisterFarm.Boundaries;
using Domain.Farms;
using Domain.Farms.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Farms.UseCases.RegisterFarm
{
    public class FarmFindAllPaginatedUseCase : IFarmFindAllPaginatedUseCase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFarmFindAllPaginatedOutputPort _outputPort;
        private readonly IFarmService _farmService;

        public FarmFindAllPaginatedUseCase(IUnitOfWork unitOfWork,
            IFarmFindAllPaginatedOutputPort outputPort,
            IFarmService farmService)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _farmService = farmService;
        }

        public async Task ExecuteAsync(FarmFindAllPaginatedInput input)
        {
            var farms = await _farmService.FindAllPaginatedAsync(input.Top, input.Skip);
            var total = await _farmService.CountAllAsync();

            BuildOutput(farms, total);
        }

        private void BuildOutput(IEnumerable<IFarm> farms, long count)
        {
            _outputPort.Standard(new FarmFindAllPaginatedOutput(
                count,
                farms)
            );
        }
    }
}
