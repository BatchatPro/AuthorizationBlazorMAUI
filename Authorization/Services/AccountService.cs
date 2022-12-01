using Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization.Services;

public class AccountService : IAccountService
{
    public Task<bool> LoginAsync(LoginModel model)
    {
        throw new NotImplementedException();
    }

    public Task<bool> LogoutAsync()
    {
        throw new NotImplementedException();
    }

    public bool ValidateLogin(out string jwtToken, LoginModel loginModel)
    {
        if (loginModel.Username.Equals("batchat_pro") && loginModel.Password.Equals("12345678"))
        {
            jwtToken = "token_123456";
            return true;
        }

        //Not valid
        jwtToken = null;
        loginModel.LoginFailureHidden = false;
        return false;
    }
}
