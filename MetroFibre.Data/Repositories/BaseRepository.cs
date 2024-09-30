using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

using MetroFibre.Data.Contexts;
using MetroFibre.Data.Interfaces;

namespace MetroFibre.Data.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly FoodDbContext _context;

    public BaseRepository(FoodDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> AllAsNoTrackingAsync()
    {
        var results = await AsSet()
            .AsNoTracking<T>()
            .ToListAsync();

        return results;
    }

    public async Task<IQueryable<T>> Where(Expression<Func<T, bool>> predicate)
    {
        var results = AsSet()
            .Where(predicate);

        return results;
    }

    public async Task<T> Find(int id)
    {
        var results = await AsSet()
            .FindAsync(id);

        return results;
    }

    protected DbSet<T> AsSet()
    {
        return _context.Set<T>();
    }

    public DbContext GetDbContext()
    {
        return _context;
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}