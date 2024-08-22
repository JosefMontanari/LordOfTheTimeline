using Backend.Database;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repos
{
	public class LotrCardRepo(ApplicationDbContext context)
	{
		public List<LotrCardModel> Cards { get; set; } = new List<LotrCardModel>();

		public async Task<List<LotrCardModel>> GetAllCardsAsync()
		{
			return await context.LotrCard
			.ToListAsync();
		}

		public async Task<LotrCardModel> GetCardById(int id)
		{
			return await context.LotrCard.FirstOrDefaultAsync(c => c.Id == id);

		}
		public async Task PostNewCard(LotrCardModel card)
		{
			//Posta ett nytt kort, alla nullchecks bör göras i react på admindashboarden innan cardet postas
			//Eftersom det där kan göras conditions för om kortet ska ha alla värden eller vissa ska vara null

			await context.LotrCard.AddAsync(card);
			await context.SaveChangesAsync();
		}
	}
}
