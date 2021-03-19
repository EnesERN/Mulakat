using Microsoft.EntityFrameworkCore;
using Mulakat.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mulakat.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private MulakatContext _context;
        private DbSet<T> _entities;

        public GenericRepository(MulakatContext context)
        {
            _context = context;
        }

        protected MulakatContext DataContext
        {
            get { return _context; }
        }

        public virtual IQueryable<T> Table => this.Entities;

        public virtual IQueryable<T> TableNoTracking => this.Entities.AsNoTracking();

        protected virtual DbSet<T> Entities => _entities ?? DataContext.Set<T>();

        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await this.Entities.Where(predicate).SingleOrDefaultAsync();
        }

        public virtual async Task<T> GetByIdAsync(object id)
        {
            return await this.Entities.FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> predicate)
        {
            return await this.Entities.Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this.Entities.ToListAsync();
        }

        public virtual async Task Insert(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                await this.Entities.AddAsync(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual async Task Insert(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");

                await this.Entities.AddRangeAsync(entities);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                this.Entities.Attach(entity);
                DataContext.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual void Update(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");

                foreach (var entity in entities)
                {
                    this.Entities.Attach(entity);
                    DataContext.Entry(entity).State = EntityState.Modified;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual void Update(T entity, params Expression<Func<T, object>>[] noUpdateProperties)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentException("entity");

                this.Entities.Attach(entity);
                DataContext.Entry(entity).State = EntityState.Modified;

                foreach (var property in noUpdateProperties)
                {
                    DataContext.Entry(entity).Property(property).IsModified = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual void Delete(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentException("entity");

                this.Entities.Remove(entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public virtual void Delete(IEnumerable<T> entities)
        {
            try
            {
                if (entities == null)
                    throw new ArgumentNullException("entities");

                foreach (var entity in entities)
                {
                    this.Entities.Remove(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task SqlCommandCRUDAsync(string command)
        {
            try
            {
                await _context.Database.ExecuteSqlRawAsync(command);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
