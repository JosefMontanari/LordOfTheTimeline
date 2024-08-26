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
		),
		new LotrCardModel(
			15, // Id
			"Lord of The Rings", // Kategori
			"Battle of Five Armies", // Fråga
			"trivia", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			2941, // År
			11, // Månad
			23, // Dag
			true, // Händer det i Lotr eller the hobbit?
			true // Är det ett "great happening" som ska vara med i alla quiz?
		),

		new LotrCardModel(
			16, // Id
			"Lord of The Rings", // Kategori
			"Death of Smaug", // Fråga
			"The name Smaug is related to the Swedish word \"smyga}\" which means to creep", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			2941, // År
			11, // Månad
			1, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
		new LotrCardModel(
			17, // Id
			"Lord of The Rings", // Kategori
			"Sauron returns to Mordor", // Fråga
			"Sauron left Dol Goldur only to later send his Nazgûl to re-occupy it", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			2942, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			18, // Id
			"Lord of The Rings", // Kategori
			"Birth of Theoden", // Fråga
			"Theoden was actually born in Gondor, not in Rohan", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			2948, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			19, // Id
			"Lord of The Rings", // Kategori
			"Death of Aragorn", // Fråga
			"Aragorn died at the age of 210", // Trivia
			null, // WikiUrl
			Ages.fourthAge, // Tidsålder
			DifficultyRating.Easy, //Svårighetsgrad
			120, // År
			3, // Månad
			1, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			20, // Id
			"Lord of The Rings", // Kategori
			"Bilbos birthday party", // Fråga
			"Altough not very well emphazised, this was also Frodos 33th birthday party", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Easy, //Svårighetsgrad
			3001, // År
			9, // Månad
			22, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			21, // Id
			"Lord of The Rings", // Kategori
			"Frodo comes in possession of The One Ring", // Fråga
			"This was the only time any one had ever willingly given up the ring so far in history", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Easy, //Svårighetsgrad
			3001, // År
			9, // Månad
			22, // Dag
			true, // Händer det i Lotr eller the hobbit?
			true // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			22, // Id
			"Lord of The Rings", // Kategori
			"War of the Ring begins", // Fråga
			"The war officially began after Saurons forces took Osgiliath", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3019, // År
			6, // Månad
			20, // Dag
			true, // Händer det i Lotr eller the hobbit?
			true // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			23, // Id
			"Lord of The Rings", // Kategori
			"Council of Elrond", // Fråga
			"Elrond had not sent invitations, Legolas, Gimli and Boromir just happened to be in Rivendell for different reasons", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3018, // År
			10, // Månad
			25, // Dag
			true, // Händer det i Lotr eller the hobbit?
			true // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			24, // Id
			"Lord of The Rings", // Kategori
			"Gandalf falls from the bridge of Khazad-dûm", // Fråga
			"The battle between Gandalf and the Balrog persisted for ten days", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			1, // Månad
			15, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			25, // Id
			"Lord of The Rings", // Kategori
			"Gandalf dies and returns as Gandalf the White", // Fråga
			"Gandalf is the second person ever to be resurected after figting a Balrog, Glorfindel was the first", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			1, // Månad
			25, // Dag
			true, // Händer det i Lotr eller the hobbit?
			true // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			26, // Id
			"Lord of The Rings", // Kategori
			"Battle of Isengard", // Fråga
			"Isengard means \"Iron-enclosure\" in Old English", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			3, // Månad
			3, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			27, // Id
			"Lord of The Rings", // Kategori
			"Death of Denethor II", // Fråga
			"In The Return of the King Denethor is described as looking \"indeed much more like a great Wizard than Gandalf did\"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			3, // Månad
			15, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			28, // Id
			"Lord of The Rings", // Kategori
			"Death of Theoden", // Fråga
			"In the books, Theoden never gets to say farewell to Éowyn since her secret indentity is never revealed to him", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			3, // Månad
			15, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			29, // Id
			"Lord of The Rings", // Kategori
			"Death of the Witch King", // Fråga
			"It is now known who the Witch King was prior to being made a ring wraith", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3021, // År
			3, // Månad
			15, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			30, // Id
			"Lord of The Rings", // Kategori
			"Battle of the Morannon (Black Gate)", // Fråga
			"In the movie adaptation, Sauron was orignally meant to be present at the battle. This was later cut out", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Easy, //Svårighetsgrad
			3019, // År
			3, // Månad
			25, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			31, // Id
			"Lord of The Rings", // Kategori
			"Death of Isildur", // Fråga
			"Before Númenor fell, Isildur took a seedling of the white tree Nimloth with him to Middle Earth. This became the first white tree of Gondor", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			2, // År
			10, // Månad
			5, // Dag
			true, // Händer det i Lotr eller the hobbit?
			true // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			32, // Id
			"Lord of The Rings", // Kategori
			"Death of Elendil", // Fråga
			"Elendil was (approximately) 2 meters and 41 centimeters tall", // Trivia
			null, // WikiUrl
			Ages.secondAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3441, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			33, // Id
			"Lord of The Rings", // Kategori
			"Downfall of Númenor", // Fråga
			"Inspired by Tolkiens recurring dreams of a great wave, a dream he later gave to Faramir in the books", // Trivia
			null, // WikiUrl
			Ages.secondAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3319, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			34, // Id
			"Lord of The Rings", // Kategori
			"War of the Last Alliance", // Fråga
			"Although called \"The last alliance of Elves and Men\" there where Dwarves there too", // Trivia
			null, // WikiUrl
			Ages.secondAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3429, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			35, // Id
			"Lord of The Rings", // Kategori
			"Isildur plants a sapling of the White Tree in Minas Anor", // Fråga
			"Minas Anor was later renamed Minas Tirith", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			2, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			36, // Id
			"Lord of The Rings", // Kategori
			"Birth of Arwen", // Fråga
			"Arwen was said to be the fairest of all living beings in the third age", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			241, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			37, // Id
			"Lord of The Rings", // Kategori
			"The Nazgûl reappear in Middle Earth", // Fråga
			"Out of the nine only one, Khamûl, is ever named", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Extreme, //Svårighetsgrad
			1300, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			38, // Id
			"Lord of The Rings", // Kategori
			"Creation of the Shire", // Fråga
			"After the War of the Ring, The shire was gifted more land from Aragorn", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1601, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			39, // Id
			"Lord of The Rings", // Kategori
			"Destruction of Arnor", // Fråga
			"The kingdom af Arnor was later restored by Aragorn", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1974, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			40, // Id
			"Lord of The Rings", // Kategori
			"Minas Tirith is besieged", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			3, // Månad
			14, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			41, // Id
			"Lord of The Rings", // Kategori
			"The hobbits reach Bree", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3018, // År
			9, // Månad
			29, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			41, // Id
			"Lord of The Rings", // Kategori
			"Frodo wakes up in Rivendell after recovering from his wound", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3018, // År
			10, // Månad
			24, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			42, // Id
			"Lord of The Rings", // Kategori
			"The fellowship reaches the gate of Moria", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			1, // Månad
			13, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			43, // Id
			"Lord of The Rings", // Kategori
			"The fellowship reaches Lothlórien", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			2, // Månad
			15, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			44, // Id
			"Lord of The Rings", // Kategori
			"The fellowship passes the Argonath", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			2, // Månad
			25, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			45, // Id
			"Lord of The Rings", // Kategori
			"Boromir is slain", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			2, // Månad
			26, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
		new LotrCardModel(
			46, // Id
			"Lord of The Rings", // Kategori
			"Pippin looks into the Orthanc-stone", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3019, // År
			3, // Månad
			5, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
		new LotrCardModel(
			47, // Id
			"Lord of The Rings", // Kategori
			"Frodo and Sam reach Henneth Annûn", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3019, // År
			3, // Månad
			7, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
		new LotrCardModel(
			48, // Id
			"Lord of The Rings", // Kategori
			"The Dawnless Day", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3019, // År
			3, // Månad
			10, // Dag
			true, // Händer det i Lotr eller the hobbit?
			true // Är det ett "great happening" som ska vara med i alla quiz?
		),
		new LotrCardModel(
			49, // Id
			"Lord of The Rings", // Kategori
			"Second assault on Lothlórien", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Extreme, //Svårighetsgrad
			3019, // År
			3, // Månad
			15, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		)

		);
		}
	}
}
