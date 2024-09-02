using Backend.Database;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repos
{
	public class LotrCardRepo(ApplicationDbContext context) : GenericRepo<LotrCardModel>(context)
	{
		private readonly ApplicationDbContext context = context;

		public async Task<List<LotrCardModel>> GetCardInLotrAndHobbitAsync()
		{
			return await context.LotrCard.Where(c => c.IsLotrOrTheHobbit == true).ToListAsync();
		}
	}
}
