using Core.Identity;

namespace Core.Interfaces
{
    public interface ITokenService
    {
        string CreatedToken(AppUser user);
    }
}