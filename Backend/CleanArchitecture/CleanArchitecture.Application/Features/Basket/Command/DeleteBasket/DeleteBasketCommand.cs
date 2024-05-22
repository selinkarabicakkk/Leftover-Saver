using CleanArchitecture.Core.Entities;
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
    public class DeleteBasketCommand : IRequest<Response<int>>
    {
        public int CustomerId { get; set; }


        /* public DeleteBasketCommand(int customerId)
         {
             CustomerId = customerId;
         }*/
    }

        public class DeleteBasketCommandHandler : IRequestHandler<DeleteBasketCommand, Response<int>>
        {
            private readonly IBasketRepositoryAsync _basketRepository;
            private readonly ICustomerRepositoryAsync _customerRepository;

            public DeleteBasketCommandHandler(IBasketRepositoryAsync basketRepository, ICustomerRepositoryAsync customerRepository)
            {
                _basketRepository = basketRepository;
                _customerRepository = customerRepository;
            }

            public async Task<Response<int>> Handle(DeleteBasketCommand request, CancellationToken cancellationToken)
            {
                var customer = await _customerRepository.GetByIdAsync(request.CustomerId);

                if (customer == null)
                {
                    throw new ApiException("Customer not found");
                }

                var basket = customer.Basket;

                if (basket == null)
                {
                    throw new ApiException("Basket not found");
                }

                await _basketRepository.DeleteAsync(basket);

                customer.Basket = null;
                await _customerRepository.UpdateAsync(customer);

                return new Response<int>(basket.Id);
            }
        }
    


}