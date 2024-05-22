using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Infrastructure.Contexts;
using CleanArchitecture.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class BasketRepositoryAsync : GenericRepositoryAsync<Basket>, IBasketRepositoryAsync
    {
        private readonly DbSet<Basket> _baskets;

        public BasketRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _baskets = dbContext.Set<Basket>();
        }

        public async Task<Basket> GetByIdWithItemsAsync(int basketId)
        {
            return await _baskets
                .Include(b => b.BasketItems)
                .FirstOrDefaultAsync(b => b.Id == basketId);
        }
    }
}