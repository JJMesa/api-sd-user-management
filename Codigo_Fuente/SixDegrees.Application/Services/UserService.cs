using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SixDegrees.Application.Builders;
using SixDegrees.Application.Commons;
using SixDegrees.Application.Interfaces.Repositories;
using SixDegrees.Application.Wrappers;
using SixDegrees.Entities;

namespace SixDegrees.Application.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<JsonResponse<IEnumerable<User>>> GetAsync(CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAsync(cancellationToken);
            return ResponseBuilder<IEnumerable<User>>.Ok(users);
        }

        public async Task<JsonResponse<User>> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(id, cancellationToken);
            if (user is null) return ResponseBuilder<User>.NotFound();
            return ResponseBuilder<User>.Ok(user);
        }

        public async Task<JsonResponse<User>> CreateAsync(User userCreation)
        {
            await _userRepository.CreateAsync(userCreation);
            return ResponseBuilder<User>.Created(userCreation);
        }

        public async Task<JsonResponse<User>> UpdateAsync(int id, User userUpdate)
        {
            if (id != userUpdate.UserId)
                return ResponseBuilder<User>.BadRequest(ErrorMessages.UrlAndBodyIdNotEqual);

            var user = await _userRepository.GetByIdAsync(id);
            if (user is null) return ResponseBuilder<User>.NotFound();

            user.Name = userUpdate.Name;
            user.LastName = userUpdate.LastName;

            await _userRepository.UpdateAsync(user);
            return ResponseBuilder<User>.Ok(user);
        }

        public async Task<JsonResponse<bool?>> DeleteAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user is null) return ResponseBuilder<bool?>.NotFound();
            await _userRepository.DeleteAsync(user);
            return ResponseBuilder<bool?>.NoContent();
        }
    }
}
