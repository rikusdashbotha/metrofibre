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
}