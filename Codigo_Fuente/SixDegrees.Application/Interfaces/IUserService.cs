using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SixDegrees.Application.Wrappers;
using SixDegrees.Entities;

namespace SixDegrees.Application.Services
{
    public interface IUserService
    {
        Task<JsonResponse<IEnumerable<User>>> GetAsync(CancellationToken cancellationToken);
        Task<JsonResponse<User>> GetByIdAsync(long id, CancellationToken cancellationToken);
        Task<JsonResponse<User>> CreateAsync(User usuario);
        Task<JsonResponse<User>> UpdateAsync(int id, User usuario);
        Task<JsonResponse<bool?>> DeleteAsync(int id);
    }
}