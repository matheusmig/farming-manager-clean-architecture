using Application.Farms.Boundaries;
using Application.Farms.UseCases.RegisterFarm.Boundaries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.UseCases.V1.Farms.RegisterFarm
{
    public class RegisterFarmPresenter : IFarmRegisterOutputPort
    {
        public IActionResult ViewModel { get; private set; }
        public RegisterFarmResponse Response { get; private set; }

        public void Standard(FarmStandardOutput output)
        {
            Response = new RegisterFarmResponse(output.Farm);

            ViewModel = new OkObjectResult(Response);
        }

        public void FarmAlreadyRegistered(string message)
        {
            ViewModel = new BadRequestObjectResult(message);
        }
    }
}
