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
		new LotrCardModel(
		1, 
		"Lord of The Rings",
		"The One Ring is destroyed in Mount Doom", 
		"In a letter Tolkien wrote that Gollum tripping into the fires of Mt Doom was the result of divine intervention", 
		"https://lord-of-the-rings.fandom.com/wiki/Quest_of_the_Ring#Mount_Doom", 
		Ages.thirdAge, 
		DifficultyRating.Easy,
		3019, 
		3, 
		25, 
		true, 
		true),

		new LotrCardModel(
		2, 
		"Lord of The Rings",
		"Frodo is born", 
		"In an early draft Frodo was actually named Bingo, and was the son of Bilbo", 
		"https://lord-of-the-rings.fandom.com/wiki/Frodo_Baggins", 
		Ages.thirdAge, 
		DifficultyRating.Normal,
		2968, 
		9, 
		22, 
		true, 
		true),

		new LotrCardModel(
		3, 
		"Lord of The Rings", 
		"Aragorn is born",
		"Aragorns birth name was Estel", 
		"https://tolkiengateway.net/wiki/Aragorn", 
		Ages.thirdAge, 
		DifficultyRating.Normal,
		2931, 
		3, 
		1, 
		true, 
		true),

		new LotrCardModel(
		4, 
		"Lord of The Rings", 
		"The One Ring is made", 
		"The One Ring was the only one of the primary rings that didn't hold a gem stone", 
		"https://tolkiengateway.net/wiki/The_One_Ring", 
		Ages.secondAge, 
		DifficultyRating.Easy,
		1600,
		null,
		null, 
		false, 
		null),

		new LotrCardModel(
		5, 
		"Lord of The Rings", 
		"Death of Celebrimbor", 
		"Celebrimbor is the grandson of Fëanor", 
		"https://tolkiengateway.net/wiki/Celebrimbor", 
		Ages.secondAge, 
		DifficultyRating.Hard,
		1697, 
		null, 
		null, 
		false, 
		null),

		new LotrCardModel(
			6,
			"Lord of The Rings",
			"The siege of Helms deep",
			"In the movies, Peter Jackson first wanted Arwen to fight alongside the three hunters but later cut her out of the scenes",
			"https://lord-of-the-rings.fandom.com/wiki/Helm%27s_Deep#History",
			Ages.thirdAge,
			DifficultyRating.Easy,
			3019,
			3,
			3,
			true,
			false
		),

		new LotrCardModel(
			7,
			"Lord of The Rings",
			"Bilbo finds The One Ring",
			"In the first edition of The Hobbit, Gollum gives The Ring willingly to Bilbo after the game of riddles",
			"https://lord-of-the-rings.fandom.com/wiki/Bilbo_Baggins?so=search#Discovery_of_the_One_Ring",
			Ages.thirdAge,
			DifficultyRating.Easy,
			2941,
			7,
			1,
			true,
			true
		),

		new LotrCardModel(
			8,
			"Lord of The Rings",
			"Sauron returns to Dol Goldur",
			"For a long time, many believed Dol Goldur was inhabited by a mere necromancer. Gandalf suspected it was Sauron.",
			"https://lord-of-the-rings.fandom.com/wiki/Sauron#The_Necromancer_of_Dol_Guldur",
			Ages.thirdAge,
			DifficultyRating.Hard,
			2460,
			null,
			null,
			false,
			null
		),
		new LotrCardModel(
			9,
			"Lord of The Rings",
			"Birth of Bilbo Baggins",
			"In Peter Jacksons adaptation of Lord of The Rings Bilbo was played by Ian Holm. Holm played Frodo in BBC's radio adaptation of the books",
			"https://lord-of-the-rings.fandom.com/wiki/Bilbo_Baggins",
			Ages.thirdAge,
			DifficultyRating.Normal,
			2890,
			9,
			22,
			true,
			true
		),
		new LotrCardModel(
			10,
			"Lord of The Rings",
			"The fellowship leaves Rivendell",
			"The famous meme from the movies of Boromir in the council of Elrond is the result of Sean Bean reading his lines from the script during filming",
			"https://lord-of-the-rings.fandom.com/wiki/Quest_of_the_Ring#Council_of_Elrond",
			Ages.thirdAge,
			DifficultyRating.Easy,
			3018,
			12,
			25,
			true,
			true
		),
		new LotrCardModel(
			11,
			"Lord of The Rings",
			"Coronation of Aragorn",
			"Aragorns royal name is Elessar Telcontar, Telcontar is Elvish (Sindarin) for Strider",
			"https://lord-of-the-rings.fandom.com/wiki/Aragorn_II#As_King_of_Reunited_Gondor_and_Arnor",
			Ages.thirdAge,
			DifficultyRating.Easy,
			3019,
			5,
			1,
			true,
			true
		),
		new LotrCardModel(
			12,
			"Lord of The Rings",
			"Battle of Bywater",
			"The Battle of Bywater marks the end of the war of The Ring",
			"https://lord-of-the-rings.fandom.com/wiki/Battle_of_Bywater",
			Ages.thirdAge,
			DifficultyRating.Hard,
			3019,
			11,
			3,
			true,
			false

		),
		new LotrCardModel(
			13,
			"Lord of The Rings",
			"Marriage of Samwise Gamgee and Rose \"Rosie\" Cotton",
			"Sam and Rose had thirteen children, four of which were named Bilbo, Frodo, Merry and Pippin",
			"https://lord-of-the-rings.fandom.com/wiki/Samwise_Gamgee#After_the_War_of_the_Ring",
			Ages.thirdAge,
			DifficultyRating.Normal,
			3020,
			5,
			1,
			true,
			false
		),
		new LotrCardModel(
			14,
			"Lord of The Rings",
			"Gandalf, Frodo and Bilbo leave Middle Earth",
			"Samwise later leaves Middle Earth to spend his last days with Frodo in the undying lands",
			"https://lord-of-the-rings.fandom.com/wiki/Frodo_Baggins#Close_of_the_Third_Age",
			Ages.thirdAge,
			DifficultyRating.Easy,
			3021,
			9,
			22,
			true,
			true
		)

		);
		}
	}
}
