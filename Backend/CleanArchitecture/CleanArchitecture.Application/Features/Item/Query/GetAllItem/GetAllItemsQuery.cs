using AutoMapper;
using CleanArchitecture.Core.Wrappers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CleanArchitecture.Core.Interfaces.Repositories;

namespace CleanArchitecture.Core.Features.Item.Query.GetAllItem
{
    public class GetAllItemsQuery : IRequest<PagedResponse<IEnumerable<GetAllItemsViewModel>>>
    {
        public int pageNumber { get; set; }
        public int pageSize { get; set; }


    }
    public class GetAllItemsQueryHandler : IRequestHandler<GetAllItemsQuery, PagedResponse<IEnumerable<GetAllItemsViewModel>>>
    {
        private readonly IItemRepositoryAsync _itemRepository;
        private readonly IMapper _mapper;
        public GetAllItemsQueryHandler(
            IItemRepositoryAsync itemRepository,
            IMapper mapper)
        {
            _itemRepository = itemRepository;
            _mapper = mapper;
        }

        public async Task<PagedResponse<IEnumerable<GetAllItemsViewModel>>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            var validFilter = _mapper.Map<GetAllItemsParameter>(request);
            var result = await _itemRepository.GetPagedReponseAsync(validFilter.PageNumber, validFilter.PageSize);
            var viewModels = _mapper.Map<IEnumerable<GetAllItemsViewModel>>(result);
            return new PagedResponse<IEnumerable<GetAllItemsViewModel>>(viewModels, validFilter.PageNumber, validFilter.PageSize); ;
        }
    }
}
