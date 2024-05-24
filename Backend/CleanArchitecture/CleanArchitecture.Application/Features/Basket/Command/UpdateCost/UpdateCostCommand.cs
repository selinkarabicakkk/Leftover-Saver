using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace CleanArchitecture.Core.Features.Basket.Command.UpdateCost
{
    public class UpdateCostCommand : IRequest<Response<int>>
    {
        public int CartId { get; set; }


        public class UpdateCostCommandHandler : IRequestHandler<UpdateCostCommand, Response<int>>
        {
            private readonly ICartRepositoryAsync _cartRepository;

            public UpdateCostCommandHandler(ICartRepositoryAsync basketRepository)
            {
                _cartRepository = basketRepository;
            }
            public async Task<Response<int>> Handle(UpdateCostCommand command, CancellationToken cancellationToken)
            {
                var basket = await _cartRepository.GetByIdWithItemsAsync(command.CartId);

                if (basket == null) throw new EntityNotFoundException("Basket", command.CartId);

                basket.price = basket.CartItems.Sum(item => item.price * item.pieceNumber);

                await _cartRepository.UpdateAsync(basket);

                return new Response<int>(basket.Id);
            }
        }
       
    }
}