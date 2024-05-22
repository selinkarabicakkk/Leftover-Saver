using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using System.Threading.Tasks;
using System.Threading;
using CleanArchitecture.Core.Wrappers;
using MediatR;

    
    namespace CleanArchitecture.Core.Features.Basket.Commands.CreateBasket
    {
        public class CreateBasketCommand : IRequest<Response<int>>
        {
            public int CustomerId { get; set; }
            public int ItemId { get; set; }
            public double Price { get; set; }
        public List<BasketItem> BasketItems { get; set; }

       
        }

    public class CreateBasketCommandHandler : IRequestHandler<CreateBasketCommand, Response<int>>
    {
        private readonly IBasketRepositoryAsync _basketRepository;
        private readonly ICustomerRepositoryAsync _customerRepository;

        public CreateBasketCommandHandler(IBasketRepositoryAsync basketRepository, ICustomerRepositoryAsync customerRepository)
        {
            _basketRepository = basketRepository;
            _customerRepository = customerRepository;
        }

        public async Task<Response<int>> Handle(CreateBasketCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.GetByIdAsync(request.CustomerId);

            if (customer == null)
            {
                return new Response<int>("Customer not found");
            }

            var basket = new Entities.Basket
            {
                Id = request.ItemId,
                price = request.Price,
                BasketItems = new List<BasketItem>() // Initialize with empty list
            };

            await _basketRepository.AddAsync(basket);

            customer.Basket = basket;
            await _customerRepository.UpdateAsync(customer);

            return new Response<int>(basket.Id);
        }
    }


}

