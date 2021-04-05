using System.Threading.Tasks;
using IdentityModel.Client;

namespace weathermvc.Services
{
  public interface ITokenService
  {
    Task<TokenResponse> GetToken(string scope);
  }
}