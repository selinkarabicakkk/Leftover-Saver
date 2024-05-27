using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CleanArchitecture.Core.Features.CartItem.Command.DeleteCartItem
{
    public class DeleteCartItemCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
    }

    public class DeleteCartItemCommandHandler : IRequestHandler<DeleteCartItemCommand, Response<int>>
    {
        private readonly ICartItemRepositoryAsync _cartItemRepository;

        public DeleteCartItemCommandHandler(ICartItemRepositoryAsync cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<Response<int>> Handle(DeleteCartItemCommand request, CancellationToken cancellationToken)
        {
            var cartItem = await _cartItemRepository.GetCartItemByIdAsync(request.Id);
            if (cartItem == null)
            {
                throw new ApiException("CartItem not found");
            }

            await _cartItemRepository.DeleteAsync(cartItem);

            return new Response<int>(cartItem.CartItemId);
        }



    }

}
