using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Venta.Web.Data.Entities;
using Venta.Web.Models;

namespace Venta.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task CheckRoleAsync(string rolName);

        Task AdduserToRoleAsync(User user, string rolName);

        Task<bool> IsUserInRoleAsync(User user, string rolName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        Task<bool> DeleteUserAsync(string email);

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<SignInResult> ValidatePasswordAsync(User user, string password);
    }
}
