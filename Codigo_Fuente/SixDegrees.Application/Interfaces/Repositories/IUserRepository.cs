using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SixDegrees.Entities;

namespace SixDegrees.Application.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAsync(CancellationToken cancellationToken = default);
        Task<User> GetByIdAsync(long id, CancellationToken cancellationToken = default);
        Task CreateAsync(User usuario);
        Task UpdateAsync(User usuario);
        Task DeleteAsync(User usuario);
    }
}
