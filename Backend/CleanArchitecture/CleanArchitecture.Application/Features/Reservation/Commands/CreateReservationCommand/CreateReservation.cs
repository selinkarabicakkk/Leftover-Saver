using CleanArchitecture.Core.Features.Reservation.Commands;
using CleanArchitecture.Core.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Core.Features.Reservation.Commands.CreateReservationCommand
{
    public class CreateReservation : IRequest<int>
    {
        public int RestaurantId { get; set; }
        public int CustomerId { get; set; }
        public ICollection<Entities.ReservationItem> ReservationItems { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsCancelled { get; set; }
        public double totalPrice { get; set; }
        public string ReservationCode { get; set; }
    }

    public class AddReservationCommandHandler : IRequestHandler<CreateReservation, int>
    {
        private readonly IReservationRepositoryAsync _reservationRepositoryAsync;
      
        private readonly IReservationItemRepositoryAsync _RitemRepositoryAsync;

        public AddReservationCommandHandler(
            IReservationRepositoryAsync reservationRepositoryAsync,
           
            IReservationItemRepositoryAsync RitemRepositoryAsync)
        {
            _reservationRepositoryAsync = reservationRepositoryAsync;
            _RitemRepositoryAsync = RitemRepositoryAsync;
        }

        public async Task<int> Handle(CreateReservation request, CancellationToken cancellationToken)
        {
            // Check if Restaurant exists
           
           

            // Check if Customer exists
           

            // Calculate total price
            double totalPrice = 0.0;
            foreach (var reservationItem in request.ReservationItems)
            {
                var item = await _RitemRepositoryAsync.GetByIdAsync(reservationItem.ItemID);
                if (item == null)
                {
                    throw new InvalidOperationException($"Item with ID {reservationItem.ItemID} not found.");
                }
                totalPrice += item.Item.price * reservationItem.Quantity;
            }

            var newReservation = new Entities.Reservation
            {
                CustomerId = request.CustomerId,
                RestaurantId = request.RestaurantId,
                isDelivered = false,
                isCancelled = false,
                totalPrice = totalPrice,
                Created = DateTime.UtcNow,
                ReservationCode = Guid.NewGuid().ToString(),
                ReservationItems = request.ReservationItems
            };

            await _reservationRepositoryAsync.AddAsync(newReservation);

            return newReservation.Id;
        }
    }
}
