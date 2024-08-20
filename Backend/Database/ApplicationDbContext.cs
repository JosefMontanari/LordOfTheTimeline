using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Database
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
	{
		public DbSet<LotrCardModel> LotrCard { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.Equals(modelBuilder);
			modelBuilder.Entity<LotrCardModel>().HasData(
		new LotrCardModel(1, "Lord of The Rings", "The One Ring is destroyed in Mount Doom", null, "Trivia about The Ring", null, Ages.thirdAge, 3019, 3, 25, true, true),
		new LotrCardModel(2, "Lord of The Rings", "Frodo is born", null, "Trivia about Frodo", null, Ages.thirdAge, 2968, 9, 22, true, true),
		new LotrCardModel(3, "Lord of The Rings", "Aragorn is born", null, "Aragorns birth name was Estel", null, Ages.thirdAge, 2931, 3, 1, true, true),
		new LotrCardModel(4, "Lord of The Rings", "The One Ring is made", null, "Trivia about The One Ring", null, Ages.secondAge, 1600, null, null, false, null),
		new LotrCardModel(5, "Lord of The Rings", "Death of Celebrimbor", null, "Celebrimbor is the grandson of Fëanor", null, Ages.secondAge, 1697, null, null, false, null));

		}
	}
}
