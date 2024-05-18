using CleanArchitecture.Core.Features.Restaurant.Command.CreateRestaurant;
using CleanArchitecture.Core.Features.Restaurant.Query.GetAllRestaurants;
using CleanArchitecture.Core.Wrappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class RestaurantController : BaseApiController
    {

        [HttpPost]
        public async Task<IActionResult> Post(CreateRestaurantCommand command)
        {
            return Ok(await Mediator.Send(command));
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PagedResponse<IEnumerable<GetAllRestaurantsViewModel>>))]
        public async Task<PagedResponse<IEnumerable<GetAllRestaurantsViewModel>>> Get([FromQuery] GetAllRestaurantsParameter filter)
        {
            return await Mediator.Send(new GetAllRestaurantsQuery() { pageSize = filter.PageSize, pageNumber = filter.PageNumber });
        }
    }
}

