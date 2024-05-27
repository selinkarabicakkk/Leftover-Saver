using CleanArchitecture.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Core.Features.CartItem.Query.GetAllCartItems;
using AutoMapper;
using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Interfaces.Repositories;
using System.Threading.Tasks;
using System.Threading;

namespace CleanArchitecture.Core.Features.CartItem.Query.GetCartItemById
{

    public class GetCartItemByIdQuery : IRequest<Response<GetCartItemByIdViewModel>>
    {
        public int CartItemId { get; set; }
    }

    public class GetCartItemByIdQueryHandler : IRequestHandler<GetCartItemByIdQuery, Response<GetCartItemByIdViewModel>>
    {
        private readonly ICartItemRepositoryAsync _cartItemRepository;
        private readonly IMapper _mapper;

        public GetCartItemByIdQueryHandler(ICartItemRepositoryAsync cartItemRepository, IMapper mapper)
        {
            _cartItemRepository = cartItemRepository;
            _mapper = mapper;
        }

        public async Task<Response<GetCartItemByIdViewModel>> Handle(GetCartItemByIdQuery request, CancellationToken cancellationToken)
        {
            var cartItem = await _cartItemRepository.GetCartItemByIdAsync(request.CartItemId);
            if (cartItem == null)
            {
                throw new ApiException("CartItem not found");
            }

            var cartItemViewModel = _mapper.Map<GetCartItemByIdViewModel>(cartItem);
            return new Response<GetCartItemByIdViewModel>(cartItemViewModel);
        }
    }
}

