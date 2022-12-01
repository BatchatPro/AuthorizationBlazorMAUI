using Authorization.Models;

namespace Authorization.Services;

public interface IAccountService
{
    Task<bool> LoginAsync(LoginModel model);
    Task<bool> LogoutAsync();
}
