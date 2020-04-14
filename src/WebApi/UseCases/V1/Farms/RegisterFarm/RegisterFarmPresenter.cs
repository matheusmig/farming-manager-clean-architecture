using Application.Farms.UseCases.RegisterFarm.Boundaries;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.UseCases.V1.Farms.RegisterFarm
{
    public class RegisterFarmPresenter : IRegisterFarmOutputPort
    {
        public IActionResult ViewModel { get; private set; }
        public RegisterFarmResponse Response { get; private set; }

        public void Standard(RegisterFarmOutput output)
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
