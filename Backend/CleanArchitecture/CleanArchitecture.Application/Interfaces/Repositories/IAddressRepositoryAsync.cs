using CleanArchitecture.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces.Repositories
{
    public interface IAddressRepositoryAsync : IGenericRepositoryAsync<Address>
    {
        /* Task GetAllAddressesByUserIdAsync(int userId);*/
        Task<List<Address>> GetAllAddressesByUserNameAsync(string userName);
    }
}
