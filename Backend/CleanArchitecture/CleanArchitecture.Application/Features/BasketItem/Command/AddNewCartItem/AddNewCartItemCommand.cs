using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Wrappers;
using CleanArchitecture.Core.Exceptions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CleanArchitecture.Core.Features.BasketItem.Command.AddNewCartItem
{
    public class AddNewCartItemCommand : IRequest<Response<int>>
    {
        public int CartId { get; set; }
        public int ItemId { get; set; }
        public int pieceNumber { get; set; }
    }

    public class AddNewCartItemCommandHandler : IRequestHandler<AddNewCartItemCommand, Response<int>>
    {
        private readonly ICartRepositoryAsync _cartRepository;
        private readonly IItemRepositoryAsync _itemRepository;

        public AddNewCartItemCommandHandler(ICartRepositoryAsync cartRepository, IItemRepositoryAsync itemRepository)
        {
            _cartRepository = cartRepository;
            _itemRepository = itemRepository;
        }

        public async Task<Response<int>> Handle(AddNewCartItemCommand request, CancellationToken cancellationToken)
        {
            var basket = await _cartRepository.GetByIdAsync(request.CartId);
            if (basket == null)
            {
                throw new ApiException("Basket not found");
            }

            var item = await _itemRepository.GetByIdAsync(request.ItemId);
            if (item == null)
            {
                throw new ApiException("Item not found");
            }

            var basketItem = new Entities.CartItem
            {
                Id=request.ItemId,
                pieceNumber = request.pieceNumber,
                price = item.price 
            };

            basket.CartItems.Add(basketItem);
            await _cartRepository.UpdateAsync(basket);

            return new Response<int>(basketItem.Id);
        }
    }

    
}
