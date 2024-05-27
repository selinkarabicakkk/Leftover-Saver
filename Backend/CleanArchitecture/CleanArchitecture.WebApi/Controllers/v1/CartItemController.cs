using CleanArchitecture.Core.Features.CartItem.Command.AddNewCartItem;
using CleanArchitecture.Core.Features.CartItem.Command.DeleteCartItem;
using CleanArchitecture.Core.Features.CartItem.Command.UpdateCartItem;
using CleanArchitecture.Core.Features.CartItem.Query.GetAllCartItemsQuery;
using CleanArchitecture.Core.Features.CartItem.Query.GetCartItemById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class CartItemController : BaseApiController
    {

        private readonly IMediator _mediator;

        public CartItemController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/cartitems/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCartItemById(int id)
        {
            var query = new GetCartItemByIdQuery { CartItemId = id };
            var response = await _mediator.Send(query);

            if (!response.Succeeded)
            {
                return NotFound(response.Message);
            }

            return Ok(response);
        }

        // GET api/cartitems/cart/{cartId}
        [HttpGet("cart/{cartId}")]
        public async Task<IActionResult> GetAllCartItems(int cartId)
        {
            var query = new GetAllCartItemsQuery { CartId = cartId };
            var response = await _mediator.Send(query);

            if (!response.Succeeded)
            {
                return NotFound(response.Message);
            }

            return Ok(response);
        }

        [HttpPost]
        [Route("api/cart/additem")]
        public async Task<IActionResult> Post([FromBody] AddNewCartItemCommand command)
        {
            var response = await _mediator.Send(command);

            if (response.Succeeded)
            {
                return Ok(response.Data);
            }

            return BadRequest(response.Message);
        }

        [HttpDelete]
        [Route("api/cart/deleteitem/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteCartItemCommand { Id = id };
            var response = await _mediator.Send(command);

            if (response.Succeeded)
            {
                return Ok(response.Data);
            }

            return BadRequest(response.Message);
        }

        [HttpPut]
        [Route("api/cart/updateitem")]
        public async Task<IActionResult> Update(UpdateCartItemCommand command)
        {
            var response = await _mediator.Send(command);

            if (response.Succeeded)
            {
                return Ok(response.Data);
            }

            return BadRequest(response.Message);
        }





    }
}
