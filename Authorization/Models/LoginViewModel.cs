using System.ComponentModel.DataAnnotations;

namespace Authorization.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public bool LoginFailureHidden { get; set; } = true;

        public bool ValidateLogin(out string jwtToken)
        {
            if (Username.Equals("batchat_pro") && Password.Equals("12345678"))
            {
                jwtToken = "token_123456";
                return true;
            }

            //Not valid
            jwtToken = null;
            LoginFailureHidden = false;
            return false;
        }
    }
}
