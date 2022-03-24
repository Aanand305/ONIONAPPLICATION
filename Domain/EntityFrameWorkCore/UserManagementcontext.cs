using Microsoft.EntityFrameworkCore;
using Domain.Models;
using System;

namespace Domain.EntityFrameWorkCore
{
    public class UserManagementcontext : DbContext
    {
       public UserManagementcontext(DbContextOptions options) : base(options)
         {
    
         }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             new UserMap(modelBuilder.Entity<User>());
             new UserProfileMap(modelBuilder.Entity<UserProfile>());
         }

    }
}