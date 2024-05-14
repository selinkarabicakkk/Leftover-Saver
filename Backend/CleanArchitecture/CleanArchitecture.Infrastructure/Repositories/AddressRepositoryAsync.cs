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
    public class AddressRepositoryAsync : GenericRepositoryAsync<Address>, IAddressRepositoryAsync
    {

        private readonly DbSet<Address> addresses;

        public AddressRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            addresses = dbContext.Set<Address>();
        }
    }
}
