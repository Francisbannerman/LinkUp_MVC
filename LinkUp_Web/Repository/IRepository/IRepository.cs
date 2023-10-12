using System.Linq.Expressions;

namespace LinkUp_Web.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
        int Count(Expression<Func<T, bool>> filter = null);
        bool Exists(Expression<Func<T, bool>> filter);
        public int Max(Func<T, int> entity);
        void Edit(T entity);
    }
}