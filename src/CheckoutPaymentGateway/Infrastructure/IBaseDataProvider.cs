using System;
using System.Linq;
using System.Threading.Tasks;

namespace CheckoutPaymentGateway.Infrastructure
{
    public interface IBaseDataProvider<T>
    {
        T Insert(T entity);
        T Update(T entity);
        Task<T> GetAsync(Guid id);
        IQueryable<T> GetAll();
        Task SaveChangesAsync();
        Task<T> DeleteAsync(Guid id);
    }
}
