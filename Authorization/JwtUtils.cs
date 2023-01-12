using Dotnet_Auth.Entities;

namespace Dotnet_Auth.Authorization
{

    public interface IJwtUtils
    {
        public string GenerateJwtToken(Account account);
        public int? ValidateJwtToken(string token);
        public RefreshToken GenerateRefreshToken(string ipAddress);
    }
    public class JwtUtils : IJwtUtils
    {
        public string GenerateJwtToken(Account account)
        {
            throw new NotImplementedException();
        }

        public RefreshToken GenerateRefreshToken(string ipAddress)
        {
            throw new NotImplementedException();
        }

        public int? ValidateJwtToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
