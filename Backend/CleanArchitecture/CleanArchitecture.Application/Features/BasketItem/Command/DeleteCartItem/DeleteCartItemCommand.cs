using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CleanArchitecture.Core.Features.BasketItem.Commands.DeleteCartItem
{
    public class DeleteCartItemCommand : IRequest<Response<int>>
    {
        public int CartId { get; set; }
        public int ItemId { get; set; }
    }

    public class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand, Response<int>>
    {
        private readonly ICartRepositoryAsync _cartRepository;
        private readonly IItemRepositoryAsync _itemRepository;

        public DeleteCartItemCommandHandler(ICartRepositoryAsync cartRepository, IItemRepositoryAsync itemRepository)
        {
            _cartRepository = cartRepository;
            _itemRepository = itemRepository;
        }

        public async Task<Response<int>> Handle(DeleteCartItemCommand request, CancellationToken cancellationToken)
        {
            var cart = await _cartRepository.GetByIdAsync(request.CartId);
            if (cart == null)
            {
                throw new ApiException("Cart not found");
            }

            var cartItem = cart.CartItems.Find(ci => ci.Id == request.ItemId);
            if ( cartItem == null)
            {
                throw new ApiException("Item not found in cart");
            }

            cart.CartItems.Remove(cartItem);
            await _cartRepository.UpdateAsync(cart);

            return new Response<int>(cartItem.Id);
        }
    }
}