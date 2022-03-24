using Domain.Models;

namespace Service
{
    public interface IUserProfileService
    {
          UserProfile GetUserProfile(long id);// we can add multiple function according to requirement.
    }
}