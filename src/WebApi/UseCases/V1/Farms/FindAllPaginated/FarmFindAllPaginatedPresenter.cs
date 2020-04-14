using Application.Farms.UseCases.RegisterFarm.Boundaries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.UseCases.V1.Farms.RegisterFarm
{
    public class FarmFindAllPaginatedPresenter : IFarmFindAllPaginatedOutputPort
    {
        public IActionResult ViewModel { get; private set; }
        public FarmFindAllPaginatedResponse Response { get; private set; }

        public void Standard(FarmFindAllPaginatedOutput output)
        {
            Response = new FarmFindAllPaginatedResponse(output.Farms, output.Total);

            ViewModel = new OkObjectResult(Response);
        }

        public void FarmAlreadyRegistered(string message)
        {
            ViewModel = new BadRequestObjectResult(message);
        }
    }
}
