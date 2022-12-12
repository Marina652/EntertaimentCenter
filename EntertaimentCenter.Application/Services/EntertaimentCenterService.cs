using EntertaimentCenter.Application.DbAccess;
using EntertaimentCenter.Application.Entities;
using EntertaimentCenter.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EntertaimentCenter.Application.Services;

internal class EntertaimentCenterService<TEntity> : IServices<TEntity>
    where TEntity : BaseEntity
{
    private readonly EntertaimentCenterDbContext _dbContext;

    private readonly DbSet<TEntity> _dbSet;

    public EntertaimentCenterService(EntertaimentCenterDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }

    /// <summary>
    /// Method for create entity.
    /// </summary>
    /// <param name="obj">Entity object.</param>
    /// <returns>Entity id.</returns>
    public async Task<int> Create(TEntity obj, CancellationToken token)
    {
        await _dbSet.AddAsync(obj, token);
        await _dbContext.SaveChangesAsync(token);

        var idProperty = obj.GetType().GetProperty("Id")!.GetValue(obj, null);

        return (int)idProperty!;
    }

    /// <summary>
    /// Method for delete entity.
    /// </summary>
    /// <param name="id">Entity object.</param>
    /// <returns>True ir false.</returns>
    public async Task<bool> Delete(int id, CancellationToken token)
    {
        var obj = await _dbSet.FindAsync(id, token);

        if (obj == null)
            return false;

        _dbContext.Remove(obj);
        await _dbContext.SaveChangesAsync(token);

        return true;
    }

    /// <summary>
    /// Method for select entities.
    /// </summary>
    /// <returns>Entity collection.</returns>
    public Task<List<TEntity>> SelectAll(CancellationToken token)
    {
        return _dbSet.ToListAsync(token);
    }

    /// <summary>
    /// Method for update entity.
    /// </summary>
    /// <param name="obj">Entity object.</param>
    /// <returns>Entity model.</returns>
    public async Task<TEntity> Update(TEntity obj, CancellationToken token)
    {
        _dbSet.Update(obj);

        await _dbContext.SaveChangesAsync(token);

        return await _dbSet.FindAsync(obj.Id, token);
    }

    /// <summary>
    /// Method for entity find by id.
    /// </summary>
    /// <param name="id">Id.</param>
    /// <returns>Entity model.</returns>
    public async Task<TEntity> FindById(int id, CancellationToken token)
    {
        return await _dbSet.FindAsync(id, token);
    }
}
