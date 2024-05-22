using CleanArchitecture.Core.Features.Basket.Command.DeleteBasket;
using CleanArchitecture.Core.Features.Basket.Command.UpdateCost;
using CleanArchitecture.Core.Features.Basket.Commands.CreateBasket;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers.v1
{
    public class BasketController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Post(CreateBasketCommand command)
        {
            var response = await Mediator.Send(command);
            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        [HttpDelete("{customerId}")]
        [Authorize]
        public async Task<IActionResult> Delete(int customerId)
        {
            var command = new DeleteBasketCommand { CustomerId = customerId };
            var response = await Mediator.Send(command);
            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        
        [HttpPut("update-cost/{basketId}")]
        [Authorize]
        public async Task<IActionResult> UpdateCost(int basketId)
        {
            var command = new UpdateCostCommand { BasketId = basketId };
            var response = await Mediator.Send(command);
            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

    }
}
