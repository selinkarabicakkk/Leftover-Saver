using AutoMapper;
using CleanArchitecture.Core.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CleanArchitecture.Core.Features.Restaurant.Query.GetAllRestaurants;
using CleanArchitecture.Core.Wrappers;

namespace CleanArchitecture.Core.Features.Address.Query.GetAllAddresses
{
  
        public class GetAllAddressesQuery : IRequest<PagedResponse<IEnumerable<GetAllAddressesViewModel>>>
    {

        private readonly IAddressRepositoryAsync _addressRepository;
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string UserName { get; set; }
      
    }

    public class GetAllAddressesQueryHandler : IRequestHandler <GetAllAddressesQuery, PagedResponse<IEnumerable<GetAllAddressesViewModel>>>
        {
            private readonly IAddressRepositoryAsync _addressRepository;
            private readonly IMapper _mapper;

            public GetAllAddressesQueryHandler(IAddressRepositoryAsync addressRepository, IMapper mapper)
            {
                _addressRepository = addressRepository;
                _mapper = mapper;
            }

            public async Task<PagedResponse<IEnumerable<GetAllAddressesViewModel>>> Handle(GetAllAddressesQuery request, CancellationToken cancellationToken)
            {

            var addresses = await _addressRepository.GetAllAddressesByUserNameAsync(request.UserName);
            var addressViewModels = _mapper.Map<List<GetAllAddressesViewModel>>(addresses);
            return new PagedResponse<IEnumerable<GetAllAddressesViewModel>>(addressViewModels, request.PageNumber, request.PageSize);
           
        }
        }
    }

