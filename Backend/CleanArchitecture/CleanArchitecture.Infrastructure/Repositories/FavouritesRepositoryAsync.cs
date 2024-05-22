using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces.Repositories;
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


    }
}
