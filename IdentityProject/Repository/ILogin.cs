using IdentityProject.Models;

namespace IdentityProject.Repository
{
    public interface ILogin
    {
        Task<IEnumerable<LoginViewModel>> getuser();
        Task<LoginViewModel> AuthenticateUser(string username, string passcode);
    }
}
