using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CleanArchitecture.Core.Features.CartItem.Command.UpdateCartItem
{
    public class UpdateCartItemCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public int pieceNumber { get; set; }
    }

    public class UpdateCartItemCommandHandler : IRequestHandler<UpdateCartItemCommand, Response<int>>
    {
        private readonly ICartItemRepositoryAsync _cartItemRepository;

        public UpdateCartItemCommandHandler(ICartItemRepositoryAsync cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        public async Task<Response<int>> Handle(UpdateCartItemCommand request, CancellationToken cancellationToken)
        {
            var cartItem = await _cartItemRepository.GetCartItemByIdAsync(request.Id);
            if (cartItem == null)
            {
                throw new ApiException("CartItem not found");
            }

            cartItem.pieceNumber = request.pieceNumber;
            await _cartItemRepository.UpdateAsync(cartItem);

            return new Response<int>(cartItem.CartItemId);
        }
    }

}
