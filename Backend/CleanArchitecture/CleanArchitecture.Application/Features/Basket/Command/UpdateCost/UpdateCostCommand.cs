using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace CleanArchitecture.Core.Features.Basket.Command.UpdateCost
{
    public class UpdateCostCommand : IRequest<Response<int>>
    {
        public int BasketId { get; set; }


        public class UpdateCostCommandHandler : IRequestHandler<UpdateCostCommand, Response<int>>
        {
            private readonly IBasketRepositoryAsync _basketRepository;

            public UpdateCostCommandHandler(IBasketRepositoryAsync basketRepository)
            {
                _basketRepository = basketRepository;
            }
            public async Task<Response<int>> Handle(UpdateCostCommand command, CancellationToken cancellationToken)
            {
                var basket = await _basketRepository.GetByIdWithItemsAsync(command.BasketId);

                if (basket == null) throw new EntityNotFoundException("Basket", command.BasketId);

                basket.price = basket.BasketItems.Sum(item => item.price * item.pieceNumber);

                await _basketRepository.UpdateAsync(basket);

                return new Response<int>(basket.Id);
            }
        }
       
    }
}