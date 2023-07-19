using DomainLayer.Data;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> _entities;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();  
        }

        public void Delete(T entity)
        {
            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.Remove(entity);
            _context.SaveChanges();
           
        }

        public T Get(int Id) => _entities.SingleOrDefault(c => c.Id == Id);

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if(entity is null) 
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if(entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {

            if (entity is null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
