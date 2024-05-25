/*using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CleanArchitecture.Core.Exceptions;

namespace CleanArchitecture.Core.Features.Basket.Command.DeleteBasket
{
    public class DeleteCartCommand : IRequest<Response<int>>
    {
        public int CustomerId { get; set; }


        /* public DeleteBasketCommand(int customerId)
         {
             CustomerId = customerId;
         }
    }

        public class DeleteCartCommandHandler : IRequestHandler<DeleteCartCommand, Response<int>>
        {
            private readonly ICartRepositoryAsync _cartRepository;
            private readonly ICustomerRepositoryAsync _customerRepository;

            public DeleteCartCommandHandler(ICartRepositoryAsync cartRepository, ICustomerRepositoryAsync customerRepository)
            {
                _cartRepository = cartRepository;
                _customerRepository = customerRepository;
            }

            public async Task<Response<int>> Handle(DeleteCartCommand request, CancellationToken cancellationToken)
            {
                var customer = await _customerRepository.GetByIdAsync(request.CustomerId);

                if (customer == null)
                {
                    throw new ApiException("Customer not found");
                }

                var cart = customer.Cart;

                if (cart == null)
                {
                    throw new ApiException("Basket not found");
                }

                await _cartRepository.DeleteAsync(cart);

                customer.Cart = null;
                await _customerRepository.UpdateAsync(customer);

                return new Response<int>(cart.Id);
            }
        }
    


}*/