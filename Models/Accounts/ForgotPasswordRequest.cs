using System.ComponentModel.DataAnnotations;

namespace Dotnet_Auth.Models.Accounts
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
