using System.ComponentModel.DataAnnotations;

namespace Dotnet_Auth.Models.Accounts
{
    public class VerifyEmailRequest
    {
        [Required]
        public string Token { get; set; }
    }
}
