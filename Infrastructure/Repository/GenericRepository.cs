using System.Collections.Generic;
using Domain.Models;
using Domain.EntityFrameWorkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly UserManagementcontext userManagementcontext;

        DbSet<T> entities;
        //string errorMessage = string.Empty;
        public GenericRepository(UserManagementcontext userManagementcontext)
        {
            this.userManagementcontext = userManagementcontext;
            entities = this.userManagementcontext.Set<T>();
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            userManagementcontext.SaveChanges();

        }

        public T Get(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
             return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            userManagementcontext.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            userManagementcontext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            userManagementcontext.SaveChanges();
        }
    }
}