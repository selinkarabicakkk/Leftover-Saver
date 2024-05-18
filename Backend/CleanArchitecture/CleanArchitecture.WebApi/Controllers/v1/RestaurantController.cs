using CleanArchitecture.Core.Features.Restaurant.Command.CreateRestaurant;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers.v1
{
    public class RestaurantController :BaseApiController
    {
        [HttpPost(Name ="CreateRestaurant")]

        public async Task<int> CreateRestaurant(CreateRestaurantCommand createRestaurantCommand)
        {
            return await Mediator.Send(createRestaurantCommand);
        }
    }
}
