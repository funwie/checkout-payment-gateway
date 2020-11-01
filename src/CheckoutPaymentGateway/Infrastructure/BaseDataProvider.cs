using CheckoutPaymentGateway.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.Infrastructure
{
    public class BaseDataProvider<T> : IBaseDataProvider<T> where T : class
    {
        protected AppDbContext _dbContext;

        public BaseDataProvider(AppDbContext context)
        {
            _dbContext = context;
        }

        public T Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Insert)} entity must not be null");
            }

            try
            {
                var changedTrackedEntity = _dbContext.Set<T>().Add(entity);
                _dbContext.SaveChanges();
                return changedTrackedEntity.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved {ex.Message}");
            }
        }

        public async Task<T> GetAsync(Guid id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public IQueryable<T> GetAll()
        {
            try
            {
                return _dbContext.Set<T>().AsNoTracking();
            }
            catch (Exception)
            {
                throw new Exception("Couldn't retrieve entities");
            }

        }

        public T Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Update)} entity must not be null");
            }

            try
            {
                var changedTrackedEntity = _dbContext.Set<T>().Update(entity);
                _dbContext.SaveChanges();
                return changedTrackedEntity.Entity;
            }
            catch (Exception)
            {
                throw new Exception($"{nameof(entity)} could not be updated");
            }
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> DeleteAsync(Guid id)
        {
            var entity = await GetAsync(id);

            if (entity != null)
            {
                _dbContext.Remove(entity);
                await _dbContext.SaveChangesAsync();
            }

            return entity;
        }
    }
}
