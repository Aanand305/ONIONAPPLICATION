using Domain.Models;
using Infrastructure.Repository;

namespace Service
{
    public class UserProfileRepository : IUserProfileService
    {
        private IGenericRepository<UserProfile> userProfileRepository;
 
        public UserProfileRepository(IGenericRepository<UserProfile> userProfileRepository)
        {          
            this.userProfileRepository = userProfileRepository;
        }
 
        public UserProfile GetUserProfile(long id)
        {
             return userProfileRepository.Get(id);
        }
    }
}