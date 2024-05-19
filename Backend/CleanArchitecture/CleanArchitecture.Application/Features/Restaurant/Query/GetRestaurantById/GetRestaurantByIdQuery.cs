using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Core.Features.Restaurant.Query.GetRestaurantById
{
    public class GetRestaurantByIdQuery : IRequest<Response<Entities.Restaurant>>
    {
        public int Id { get; set; }
        public class GetRestaurantByIdQueryHandler : IRequestHandler<GetRestaurantByIdQuery, Response<Entities.Restaurant>>
        {
            private readonly IRestaurantRepositoryAsync _restaurantRepository;
            public GetRestaurantByIdQueryHandler(IRestaurantRepositoryAsync restaurantRepository)
            {
                _restaurantRepository = restaurantRepository;
            }
            public async Task<Response<Entities.Restaurant>> Handle(GetRestaurantByIdQuery query, CancellationToken cancellationToken)
            {
                var restaurant = await _restaurantRepository.GetByIdAsync(query.Id);
                if (restaurant == null) throw new ApiException($"Restaurant Not Found.");
                return new Response<Entities.Restaurant>(restaurant);
            }
        }
    }
}
