using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Features.Item.Command.CreateItem
{
    public class CreateItemCommand : IRequest<int>
    {


<<<<<<< Updated upstream
        public int RestaurantId { get; set; } // Foreign key to Business
=======
        public int RestaurantId { get; set; }
>>>>>>> Stashed changes
        public string itemName { get; set; }
        public double price { get; set; }
        public string picture { get; set; }
        public string explanation { get; set; }

    }

    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, int>
    {
        private readonly IItemRepositoryAsync _itemRepositoryAsync;



        public CreateItemCommandHandler(
            IItemRepositoryAsync itemRepositoryAsync)
        {
            _itemRepositoryAsync = itemRepositoryAsync;
        }


        public async Task<int> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var newItem = new Entities.Item
            {
<<<<<<< Updated upstream
                RestaurantId=request.RestaurantId,
=======
                RestaurantId = request.RestaurantId,
>>>>>>> Stashed changes
                itemName = request.itemName,
                price = request.price,
                picture = request.picture,
                explanation = request.explanation,
                
            };

            await _itemRepositoryAsync.AddAsync(newItem);

            return newItem.Id;
        }
    }
}