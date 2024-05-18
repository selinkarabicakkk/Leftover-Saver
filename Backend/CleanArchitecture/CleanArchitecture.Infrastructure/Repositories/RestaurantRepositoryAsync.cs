using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Infrastructure.Contexts;
using CleanArchitecture.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class RestaurantRepositoryAsync : GenericRepositoryAsync<Restaurant>, IRestaurantRepositoryAsync
    {

        private readonly DbSet<Restaurant> _restaurant;

        public RestaurantRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _restaurant = dbContext.Set<Restaurant>();
        }


    }
}
