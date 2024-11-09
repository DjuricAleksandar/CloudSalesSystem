using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

internal abstract class GenericRepository<T>(CloudSalesDbContext dbContext) : IGenericRepository<T>
    where T : BaseRecord
{
    protected readonly CloudSalesDbContext DbContext = dbContext;

    public virtual async Task<IEnumerable<T>> GetAll()
    {
        return await DbContext.Set<T>().ToListAsync();
    }

    public virtual async Task<T> Add(T entity)
    {
        await DbContext.Set<T>().AddAsync(entity);
        await DbContext.SaveChangesAsync();
        return entity;
    }
}