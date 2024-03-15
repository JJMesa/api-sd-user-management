using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SixDegrees.Application.Interfaces.Repositories;
using SixDegrees.Entities;

namespace SixDegrees.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<User>> GetAsync(CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Usuarios.ToListAsync(cancellationToken);
        }

        public async Task<User> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            return await _applicationDbContext.Usuarios.FirstOrDefaultAsync(x => x.UserId == id, cancellationToken);
        }

        public async Task CreateAsync(User usuario)
        {
            _applicationDbContext.Usuarios.Add(usuario);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(User usuario)
        {
            _applicationDbContext.Usuarios.Update(usuario);
            await _applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(User usuario)
        {
            _applicationDbContext.Usuarios.Remove(usuario);
            await _applicationDbContext.SaveChangesAsync();
        }       
    }
}
