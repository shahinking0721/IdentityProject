using Entities;
using IdentityProject.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.Repository
{
    public class AuthenticateLogin
    {
        private readonly RepositoryContext _context;

        public AuthenticateLogin(RepositoryContext context)
        {
            _context = context;
        }
        public async Task<LoginViewModel> AuthenticateUser(string username, string passcode)
        {
            var succeeded = await _context.loginViewModels.FirstOrDefaultAsync(authUser => authUser.Username == username && authUser.Password == passcode);
            return succeeded;
        }

        public async Task<IEnumerable<LoginViewModel>> getuser()
        {
            return await _context.loginViewModels.ToListAsync();
        }
    }
}
