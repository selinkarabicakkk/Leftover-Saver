using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Exceptions;
using CleanArchitecture.Core.Features.Favourites.Query.GetAllFavourites;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Core.Wrappers;
using CleanArchitecture.Infrastructure.Contexts;
using CleanArchitecture.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class FavouritesRepositoryAsync : GenericRepositoryAsync<Favourites>, IFavouritesRepositoryAsync
    {

        private readonly DbSet<Favourites> _favourite;

        public FavouritesRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _favourite = dbContext.Set<Favourites>();
        }

        public async Task<PagedResponse<IEnumerable<GetAllFavouriteViewModel>>> GetAllFavorites(int customerId, int pageNumber, int pageSize)
        {
            IQueryable<Favourites> favorites = _favourite.AsQueryable();
            // Query favorites based on customer ID
            favorites = favorites.Where(f => f.CustomerId == customerId);

            // Calculate total count before pagination
            var totalItems = await favorites.CountAsync();
            if (totalItems == 0)
            {
                throw new EntityNotFoundException("Favourites", totalItems);
            }
            // Apply pagination
            var favourites = favorites.Skip((pageNumber - 1) * pageSize)
                                       .Take(pageSize);
                                      

            // Map the retrieved favorites to view models
            var favoriteViewModels = favourites.Select(f => new GetAllFavouriteViewModel
            {
                RestaurantId = f.Id,
                RestaurantName = f.Restaurant.Name,

                // Map other properties as needed
            }).ToListAsync();

            // Create a paged response
            var pagedResponse = new PagedResponse<IEnumerable<GetAllFavouriteViewModel>>((IEnumerable<GetAllFavouriteViewModel>)favoriteViewModels, pageNumber, pageSize);

            return pagedResponse;
        }


    }
}
