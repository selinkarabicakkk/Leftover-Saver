using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Features.Restaurant.Command.DeleteRestaurant;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CleanArchitecture.Core.Entities;


namespace CleanArchitecture.Core.Features.Restaurant.Command.UpdateRestaurant
{
    public class UpdateRestaurantCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressID { get; set; }
        public string StoreType { get; set; }
        public double Rate { get; set; }
        public class UpdateRestaurantCommandHandler : IRequestHandler<UpdateRestaurantCommand, Response<int>>
        {
            private readonly IRestaurantRepositoryAsync _restaurantRepository;
            public UpdateRestaurantCommandHandler(IRestaurantRepositoryAsync restaurantRepository)
            {
                _restaurantRepository = restaurantRepository;
            }
            public async Task<Response<int>> Handle(UpdateRestaurantCommand command, CancellationToken cancellationToken)
            {
                var restaurant = await _restaurantRepository.GetByIdAsync(command.Id);

                if (restaurant == null) throw new EntityNotFoundException("restaurant", command.Id);

                restaurant.Name = command.Name;
                restaurant.Rate = command.Rate;
                restaurant.Email = command.Email;
                restaurant.Password = command.Password;
                restaurant.PhoneNumber = command.PhoneNumber;
                restaurant.AddressID = command.AddressID;
                restaurant.StoreType = command.StoreType;

                await _restaurantRepository.UpdateAsync(restaurant);

                return new Response<int>(restaurant.Id);
            }
        }
    }
}
