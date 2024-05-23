using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
using CleanArchitecture.Infrastructure.Contexts;
using CleanArchitecture.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class BasketItemRepositoryAsync : GenericRepositoryAsync<BasketItem>, IBasketItemRepositoryAsync
    {
        public BasketItemRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
