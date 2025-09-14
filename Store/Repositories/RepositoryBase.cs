using Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T :class, new()
    {

        protected readonly RepositoryContext _context;

        public RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }
        IQueryable<T> FindAll(bool trackChanges)
        {
            return trackChanges ? _context.Set<T>() : _context.Set<T>().AsNoTracking();   
        }
    }
}