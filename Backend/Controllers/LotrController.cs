using Backend.Models;
using Backend.Repos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LotrController : ControllerBase
	{
		public readonly LotrCardRepo _repo;

		public LotrController(LotrCardRepo cRepo)
		{
			_repo = cRepo;
		}

		[HttpGet]
		public async Task<List<LotrCardModel>> GetAllCards()
		{
			List<LotrCardModel> cards = await _repo.GetAllAsync();
			if (cards == null)
			{
				throw new Exception("Could not find list of cards");
			}
			return cards;
		}

		[HttpGet("lotr-hobbit")]
		public async Task<List<LotrCardModel>> GetAllInLotrAndHobbitAsync()
		{
			return await _repo.GetCardInLotrAndHobbitAsync();
		}

		[HttpGet("id")]
		public async Task<LotrCardModel?> GetCardById(int id)
		{
			return await _repo.GetByIdAsync(id);
		}

		[HttpPost]

		public async Task<LotrCardModel> PostNewCard(LotrCardModel card)
		{
			await _repo.AddAsync(card);
			return card;
		}
	}
}
