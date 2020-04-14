using Application.Farms.UseCases.RegisterFarm;
using Application.Farms.UseCases.RegisterFarm.Boundaries;
using Domain.Farms.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using WebApi.UseCases.V1.Farms.RegisterFarm;

namespace WebApi.UseCases.V1.Farms.FindAllPaginated
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class FarmController : ControllerBase
    {
        private readonly IFarmFindAllPaginatedUseCase _useCase;
        private readonly FarmFindAllPaginatedPresenter _presenter;

        public FarmController(
           IFarmFindAllPaginatedUseCase useCase,
           FarmFindAllPaginatedPresenter presenter)
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
        [HttpPost("FindAll")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FarmFindAllPaginatedResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> FindAllAsync([FromBody][Required] FarmFindAllPaginatedRequest request)
        {
            var input = new FarmFindAllPaginatedInput(request.Top, request.Skip);

            await _useCase.ExecuteAsync(input);

            return _presenter.ViewModel;
        }
    }
}
