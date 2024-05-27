using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Infrastructure.Contexts;
using CleanArchitecture.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class ItemRepositoryAsync : GenericRepositoryAsync<Item>, IItemRepositoryAsync
    {

        private readonly DbSet<Item> _item;

        public ItemRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _item = dbContext.Set<Item>();
        }


    }
}
