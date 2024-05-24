using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Infrastructure.Contexts;
using CleanArchitecture.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class CartRepositoryAsync : GenericRepositoryAsync<Cart>, ICartRepositoryAsync
    {
        private readonly DbSet<Cart> _cart;

        public CartRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _cart = dbContext.Set<Cart>();
        }

        public async Task<Cart> GetByIdWithItemsAsync(int cartId)
        {
            return await _cart
                .Include(b => b.CartItems)
                .FirstOrDefaultAsync(b => b.Id == cartId);
        }
    }
}