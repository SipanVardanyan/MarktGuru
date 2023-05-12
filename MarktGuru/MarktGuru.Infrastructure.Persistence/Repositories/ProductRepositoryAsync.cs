using MarktGuru.Application.Interfaces.Repositories;
using MarktGuru.Domain.Entities;
using MarktGuru.Infrastructure.Persistence.Contexts;
using MarktGuru.Infrastructure.Persistence.Repository;

namespace MarktGuru.Infrastructure.Persistence.Repositories
{
    public class ProductRepositoryAsync : GenericRepositoryAsync<Product>, IProductRepositoryAsync
    {
        public ProductRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
