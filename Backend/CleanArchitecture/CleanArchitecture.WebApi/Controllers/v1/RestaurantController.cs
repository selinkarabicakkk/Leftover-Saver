using CleanArchitecture.Core.Features.Restaurant.Command.CreateRestaurant;
using CleanArchitecture.Core.Features.Restaurant.Command.DeleteRestaurant;
using CleanArchitecture.Core.Features.Restaurant.Command.UpdateRestaurant;
using CleanArchitecture.Core.Features.Restaurant.Query.GetAllRestaurants;
using CleanArchitecture.Core.Features.Restaurant.Query.GetRestaurantById;
using CleanArchitecture.Core.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class RestaurantController : BaseApiController
    {
        //POST /api/restaurant
        [HttpPost]
        public async Task<IActionResult> Post(CreateRestaurantCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        //GET /api/restaurant
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PagedResponse<IEnumerable<GetAllRestaurantsViewModel>>))]
        public async Task<PagedResponse<IEnumerable<GetAllRestaurantsViewModel>>> Get([FromQuery] GetAllRestaurantsParameter filter)
        {
            return await Mediator.Send(new GetAllRestaurantsQuery() { pageSize = filter.PageSize, pageNumber = filter.PageNumber });
        }

        // DELETE /api/restaurant/{id} 
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteRestaurantCommand { Id = id }));
        }

        // PUT /api/restaurant/{id}
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, UpdateRestaurantCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

        // GET /api/restaurant/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetRestaurantByIdQuery { Id = id }));
        }
    }
}

