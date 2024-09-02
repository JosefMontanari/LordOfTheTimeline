using Backend.Database;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repos
{
	public class GenericRepo<T> where T : class
	{
		private readonly ApplicationDbContext context;
		private readonly DbSet<T> dbSet;

		public GenericRepo(ApplicationDbContext context)
		{
			this.context = context;
			dbSet = context.Set<T>();
		}

		public async Task<List<T>> GetAllAsync()
		{
			return await dbSet.ToListAsync();
		}

		public async Task<T?> GetByIdAsync(int id)
		{
			return await dbSet.FindAsync(id);
		}

		public async Task AddAsync(T model)
		{
			await dbSet.AddAsync(model);
		}
	}
}
