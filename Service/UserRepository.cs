using System.Collections.Generic;
using Domain.Models;
using Infrastructure.Repository;

namespace Service
{
    public class UserRepository : IUserService
    {
        private IGenericRepository<User> userRepository;
        private IGenericRepository<UserProfile> userProfileRepository;
 
        public UserRepository(IGenericRepository<User> userRepository, IGenericRepository<UserProfile> userProfileRepository)
        {
            this.userRepository = userRepository;
            this.userProfileRepository = userProfileRepository;
        }
        public void DeleteUser(long id)
        {
                     
            UserProfile userProfile = userProfileRepository.Get(id);
            userProfileRepository.Remove(userProfile);
            User user = GetUser(id);
            userRepository.Remove(user);
            userRepository.SaveChanges();
        }

        public User GetUser(long id)
        {
               return userRepository.Get(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetAll();
        }

        public void InsertUser(User user)
        {
             userRepository.Insert(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }
    }
}