using CleanArchitecture.Core.Features.Basket.Command.DeleteBasket;
using CleanArchitecture.Core.Features.Basket.Command.UpdateCost;
using CleanArchitecture.Core.Features.Cart.Command.CreateCart;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers.v1
{
    public class CartController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Post(CreateCartCommand command)
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
            var command = new DeleteCartCommand { CustomerId = customerId };
            var response = await Mediator.Send(command);
            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        
        [HttpPut("update-cost/{basketId}")]
        [Authorize]
        public async Task<IActionResult> UpdateCost(int cartId)
        {
            var command = new UpdateCostCommand { CartId = cartId };
            var response = await Mediator.Send(command);
            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }

        /*public async Task<IActionResult> GetAllCartItems(int cartId)
        {
            var query = new GetAllCartItemsQuery { CartId = cartId };
            var response = await Mediator.Send(query);
            if (!response.Succeeded)
            {
                return BadRequest(response.Message);
            }
            return Ok(response);
        }*/

    }
}
