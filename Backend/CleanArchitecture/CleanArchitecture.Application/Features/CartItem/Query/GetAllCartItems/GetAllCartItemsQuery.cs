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


namespace CleanArchitecture.Core.Features.CartItem.Query.GetAllCartItemsQuery
{
    
        public class GetAllCartItemsQuery : IRequest<Response<IEnumerable<GetAllCartItemsViewModel>>>

        {
            public int CartId { get; set; }
        }

        public class GetAllCartItemsQueryHandler : IRequestHandler<GetAllCartItemsQuery,Response<IEnumerable<GetAllCartItemsViewModel>>>
        {
            private readonly ICartRepositoryAsync _cartRepository;
            private readonly IMapper _mapper;

            public GetAllCartItemsQueryHandler(ICartRepositoryAsync cartRepository, IMapper mapper)
            {
                _cartRepository = cartRepository;
                _mapper = mapper;
            }

            public async Task<Response<IEnumerable<GetAllCartItemsViewModel>>> Handle(GetAllCartItemsQuery request, CancellationToken cancellationToken)
            {
                var cart = await _cartRepository.GetByIdAsync(request.CartId);
                if (cart == null)
                {
                    throw new ApiException("Cart not found");
                }

                var cartItems = _mapper.Map<IEnumerable<GetAllCartItemsViewModel>>(cart.CartItems);
                return new Response<IEnumerable<GetAllCartItemsViewModel>>(cartItems);
            }
        }
    }

