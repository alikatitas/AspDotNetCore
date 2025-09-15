using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductsRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductsRepository(RepositoryContext context) : base(context)
        {

        }

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);

    }
}