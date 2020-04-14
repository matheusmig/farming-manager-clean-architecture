using Application.Farms.UseCases.RegisterFarm;
using Application.Farms.UseCases.RegisterFarm.Boundaries;
using Domain.Farms.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebApi.UseCases.V1.Farms.RegisterFarm
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class FarmController : ControllerBase
    {
        private readonly IRegisterFarmUseCase _useCase;
        private readonly RegisterFarmPresenter _presenter;

        public FarmController(
           IRegisterFarmUseCase useCase,
           RegisterFarmPresenter presenter)
        {
            _useCase = useCase;
            _presenter = presenter;
        }

        /// <summary>
        /// Register a Farm.
        /// </summary>
        /// <response code="200">The registered farm was create successfully.</response>
        /// <response code="400">Bad request.</response>
        /// <response code="500">Error.</response>
        /// <param name="request">The request to register a farm.</param>
        /// <returns>The newly registered farm.</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(RegisterFarmResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostAsync([FromBody][Required] RegisterFarmRequest request)
        {
            var input = new RegisterFarmInput(request.Name,
                new PositiveDecimal(request.Area),
                new InscricaoEstadual(request.InscricaoEstadualState, request.InscricaoEstadualNumber));

            await _useCase.ExecuteAsync(input);

            return _presenter.ViewModel;
        }
    }
}
