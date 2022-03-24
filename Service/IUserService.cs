using System.Collections.Generic;
using Domain.Models;

namespace Service
{
    public interface IUserService
    {
         IEnumerable<User> GetUsers();
        User GetUser(long id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(long id);
    }
}