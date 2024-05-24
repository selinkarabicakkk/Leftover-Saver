using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using System.Threading.Tasks;
using System.Threading;
using CleanArchitecture.Core.Wrappers;
using MediatR;


namespace CleanArchitecture.Core.Features.Cart.Command.CreateCart
    {
        public class CreateCartCommand : IRequest<Response<int>>
        {
            public int CustomerId { get; set; }
            public int Price { get; set; }

    
        }

    public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, Response<int>>
    {
        private readonly ICartRepositoryAsync _cartRepository;
        private readonly ICustomerRepositoryAsync _customerRepository;

        public CreateCartCommandHandler(ICartRepositoryAsync cartRepository, ICustomerRepositoryAsync customerRepository)
        {
            _cartRepository = cartRepository;
            _customerRepository = customerRepository;
        }

        public async Task<Response<int>> Handle(CreateCartCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.CustomerId);

            if (customer == null)
            {
                return new Response<int>("Customer not found");
            }

            var cart = new Entities.Cart
            {
                customerId = request.CustomerId,
                price = request.Price,
                CartItems = new List<Entities.CartItem>() // Initialize with empty list
            };

            await _cartRepository.AddAsync(cart);

            customer.Cart = cart;
            await _customerRepository.UpdateAsync(customer);

            return new Response<int>(cart.Id);
        }
    }


}

