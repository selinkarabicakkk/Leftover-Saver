using CleanArchitecture.Core.Features.Item.Command.CreateItem;
using CleanArchitecture.Core.Features.Item.Command.DeleteItem;
using CleanArchitecture.Core.Features.Item.Command.UpdateItem;
using CleanArchitecture.Core.Features.Item.Query.GetAllItem;
using CleanArchitecture.Core.Features.Item.Query.GetAllItemById;
using CleanArchitecture.Core.Wrappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ItemController : BaseApiController
    {
        //POST /api/item
        [HttpPost]
        public async Task<IActionResult> Post(CreateItemCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        //GET /api/item
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PagedResponse<IEnumerable<GetAllItemsViewModel>>))]
        public async Task<PagedResponse<IEnumerable<GetAllItemsViewModel>>> Get([FromQuery] GetAllItemsParameter filter)
        {
            return await Mediator.Send(new GetAllItemsQuery() { pageSize = filter.PageSize, pageNumber = filter.PageNumber });
        }

        // DELETE /api/item/{id} 
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteItemCommand { Id = id }));
        }

        
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Put(int id, UpdateItemCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            return Ok(await Mediator.Send(command));
        }

     
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetItemByIdQuery { Id = id }));
        }
    }
}

