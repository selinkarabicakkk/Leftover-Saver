using CleanArchitecture.Core.Features.Address.Command.CreateAddress;
using CleanArchitecture.Core.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CleanArchitecture.Core.Features.Address.Command.CreateAddress
{
    public class CreateAddressCommand : IRequest<int>
    {
        public string UserName { get; set; }
        public string AddressDefinition { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string AddressTitle { get; set; }
    }

    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, int>
    {
        private readonly IAddressRepositoryAsync _addressRepositoryAsync;



        public CreateAddressCommandHandler(
            IAddressRepositoryAsync addressRepositoryAsync)
        {
            _addressRepositoryAsync = addressRepositoryAsync;
        }


        public async Task<int> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var newAddress = new Entities.Address
            {

                UserName = request.UserName,
                AddressDefinition = request.AddressDefinition,
                City = request.City,
                State = request.State,
                ZipCode = request.ZipCode,
                AddressTitle = request.AddressTitle

            };

            await _addressRepositoryAsync.AddAsync(newAddress);

            return newAddress.Id;
        }
    }
}
