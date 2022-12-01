using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization.Models
{
    public class AuthResponse
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string UserFullName { get; set; }
        public string PINFL { get; set; }
        //public string RefreshToken { get; set; }
        //[AllowNull]
        //public List<string> Access { get; set; }
    }
}
