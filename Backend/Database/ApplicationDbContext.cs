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
			3018, // År
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
			"Gandalf dies adter fighting the Balrog", // Fråga
			"Gandalf is the second person ever to be ressurected after fighting a Balrog, Glorfindel was the first", // Trivia
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
			3019, // År
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
			"Not featured in the movies, the war of the ring had several fronts inclduing Lóthlorien", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Extreme, //Svårighetsgrad
			3019, // År
			3, // Månad
			15, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			50, // Id
			"Lord of The Rings", // Kategori
			"Frodo wakes up in Rivendell after recovering from his wound", // Fråga
			"Frodo never fully recovered however, the wound pained him until his last days", // Trivia
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
			51, // Id
			"Lord of The Rings", // Kategori
			"Arwen dies in Lothlórien", // Fråga
			"Arwen dies of a broken heart, as Aragorn had died a year earlier", // Trivia
			null, // WikiUrl
			Ages.fourthAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			121, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
					new LotrCardModel(
			52, // Id
			"Lord of The Rings", // Kategori
			"Samwise Gamgee leaves Middle-earth", // Fråga
			"As a ringbearer, Sam was also eligible to leave for the undying lands", // Trivia
			null, // WikiUrl
			Ages.fourthAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			61, // År
			9, // Månad
			22, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			53, // Id
			"Lord of The Rings", // Kategori
			"Bilbo turns 131 years old", // Fråga
			"At 131 years old, Bilbo becomes the longest living hobbit in history", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3021, // År
			9, // Månad
			22, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			54, // Id
			"Lord of The Rings", // Kategori
			"Elanor, daughter of Samwise is born", // Fråga
			"The name Elanor comes from a flower in Lothlórien", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3021, // År
			3, // Månad
			25, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			55, // Id
			"Lord of The Rings", // Kategori
			"Death of Saruman", // Fråga
			"In the books, Saruman dies in The Shire after the battle of Bywater", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3019, // År
			11, // Månad
			3, // Dag
			true, // Händer det i Lotr eller the hobbit?
			true // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			56, // Id
			"Lord of The Rings", // Kategori
			"Aragorn finds a sapling of the White Tree", // Fråga
			"Tis tree is the seventh decendant in line from the Great Tree Telperion", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3019, // År
			6, // Månad
			25, // Dag
			true, // Händer det i Lotr eller the hobbit?
			true // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			57, // Id
			"Lord of The Rings", // Kategori
			"The sacking of Dol Goldur", // Fråga
			"Galadriel throws down the walls of Dol Goldur at the end of the siege", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3019, // År
			3, // Månad
			28, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			58, // Id
			"Lord of The Rings", // Kategori
			"Sam defeats Shelob", // Fråga
			"Shelob is the last descendant of Ungoliant, the spider who destroyed the Two Trees of Valinor", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			3, // Månad
			13, // Dag
			true, // Händer det i Lotr eller the hobbit?
			true // Är det ett "great happening" som ska vara med i alla quiz?
		),
			new LotrCardModel(
			59, // Id
			"Lord of The Rings", // Kategori
			"Awakening of the Elves", // Fråga
			"The Elves awake at Cuiviénen under a starlit sky as the sun and the moon aren't created yet", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1050, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?
		),
		new LotrCardModel(
			60, // Id
			"Lord of The Rings", // Kategori
			"Fingolfin challenges Morgoth", // Fråga
			"Fingolfin strikes Morgoth seven times. Morgoth walked with a limp after the duel, and the wounds he received pained him forever", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			456, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			61, // Id
			"Lord of The Rings", // Kategori
			"The last debate", // Fråga
			"The last debate was held outside of Minas Tirith, as Aragorn had decided not to enter Gondor until being accepted as King", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3019, // År
			3, // Månad
			16, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			62, // Id
			"Lord of The Rings", // Kategori
			"Gandalf arrives at Helm's Deep", // Fråga
			"In the books Gandalf arrives together with Erkenbrand, whereas in the movies he arrives with Éomer", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			3, // Månad
			4, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			63, // Id
			"Lord of The Rings", // Kategori
			"Gandalf heals Theoden", // Fråga
			"fter this, he became known as Théoden Ednew, the Renewed, because he had thrown off the yoke of Saruman.", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			3019, // År
			3, // Månad
			2, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			64, // Id
			"Lord of The Rings", // Kategori
			"The breaking of the Fellowship of The Ring", // Fråga
			"Aragorn continued to refer to the company he led as the Fellowship of the Ring even after the original Fellowship broke up.", // Trivia
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
			65, // Id
			"Lord of The Rings", // Kategori
			"Gandalf returns to life", // Fråga
			"Gandalf is the second person ever to be ressurected after fighting a Balrog, Glorfindel was the first", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3019, // År
			2, // Månad
			15, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			66, // Id
			"Lord of The Rings", // Kategori
			"Samwise Gamgee is born", // Fråga
			"J.R.R. Tolkien took the name from Gamgee Tissue,invented by a Birmingham surgeon", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			2980, // År
			4, // Månad
			6, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			67, // Id
			"Lord of The Rings", // Kategori
			"Bilbo returns to Bag End and learns he's been pronounced dead", // Fråga
			" Bilbo had to buy back his sold possessions in order to avoid quarreling with the purchasers", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			2942, // År
			6, // Månad
			22, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			68, // Id
			"Lord of The Rings", // Kategori
			"Smaug is killed", // Fråga
			"Smaug was considered the last great dragon of Middle-Earth", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Normal, //Svårighetsgrad
			2941, // År
			10, // Månad
			1, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			69, // Id
			"Lord of The Rings", // Kategori
			"Bilbo leaves Bag End with Gandalf and the thirteen dwarves", // Fråga
			"Bilbos father was name Bungo Baggins and his mother Belladonna Took, making him half a Took", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			2941, // År
			4, // Månad
			27, // Dag
			true, // Händer det i Lotr eller the hobbit?
			false // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			70, // Id
			"Lord of The Rings", // Kategori
			"The Witch King invades Arnor", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.thirdAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1409, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			71, // Id
			"Lord of The Rings", // Kategori
			"Defeat of Sauron and death of Gil-galad and Elendil", // Fråga
			"Gil-galad was burnt to death by Saurons scorching touch", // Trivia
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
			72, // Id
			"Lord of The Rings", // Kategori
			"Battle of Dagorlad and siege of Barad-dûr", // Fråga
			"The siege lated for seven years", // Trivia
			null, // WikiUrl
			Ages.secondAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			3434, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			73, // Id
			"Lord of The Rings", // Kategori
			"The Three Rings are hidden and the War of the Elves and Sauron begins", // Fråga
			"The moment Sauron puts on the One Ring the elven ring-bearers could sense it", // Trivia
			null, // WikiUrl
			Ages.secondAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1693, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			74, // Id
			"Lord of The Rings", // Kategori
			"Elrond founds Rivendell", // Fråga
			"The valley of Imladris (within which the Last Homely House was situated) was based upon the landscape of Lauterbrunnen", // Trivia
			null, // WikiUrl
			Ages.secondAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1697, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			75, // Id
			"Lord of The Rings", // Kategori
			"The war of Wrath", // Fråga
			"The battle was so intense that it lay waste to all of Beleriand and sunk it under the sea", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			545, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			76, // Id
			"Lord of The Rings", // Kategori
			"Eärendil arrives in Valinor and asks the Valar to aid in the fight again Morgoth", // Fråga
			"The name Eärendil comes from an old English poem", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			542, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			77, // Id
			"Lord of The Rings", // Kategori
			"Túrin slays Glaurung", // Fråga
			"Glaurung is known as tha father of all dragons. He could however not fly", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			499, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			78, // Id
			"Lord of The Rings", // Kategori
			"Nírnaeth Arnoediad, The Battle of Unnumbered Tears, is fought.", // Fråga
			"This battle swayed the war to Morgoths favor, it was a crushing defeat for the Elves and Men of Beleriand", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			472, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			79, // Id
			"Lord of The Rings", // Kategori
			"Fall of Gondolin", // Fråga
			"Like Gandalf, Glorfindel fought a Balrog and won. Glorfindel himself died though, and was later ressurected.", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			510, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			80, // Id
			"Lord of The Rings", // Kategori
			"Awakening of Men", // Fråga
			"Men awake as the sun rises for the first time", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			81, // Id
			"Lord of The Rings", // Kategori
			"Beren and Lúthien retrieve a Silmaril from Morgoths crown", // Fråga
			"Beren tries to take more than one Silmaril but is  in the attempt", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			466, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			82, // Id
			"Lord of The Rings", // Kategori
			"Dagor Bragollach, Battle of the Sudden Flame", // Fråga
			"This is the first battle were dragons were used", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			455, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			83, // Id
			"Lord of The Rings", // Kategori
			"Fingon rescues Maedhros from Thangorodrim", // Fråga
			"Meadhros was the oldest of Fëanors seven sons", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			5, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			84, // Id
			"Lord of The Rings", // Kategori
			"Elros is crowned the first king of Númenor", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.secondAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			32, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			85, // Id
			"Lord of The Rings", // Kategori
			"Lúthien dies", // Fråga
			"Beren and Lúthien were both revived and given mortal life, their ultimate deaths are not recorded", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			467, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			86, // Id
			"Lord of The Rings", // Kategori
			"Elrond and Elros are born", // Fråga
			"Elrond chooses and elven life and Elros the life of a man", // Trivia
			null, // WikiUrl
			Ages.firstAge, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			532, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			87, // Id
			"Lord of The Rings", // Kategori
			"Creation of the Moon and the Sun", // Fråga
			"The Sun and Moon are created from the last fruit and flower of the Two Trees respectively", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1500, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			88, // Id
			"Lord of The Rings", // Kategori
			"Fëanor is slain", // Fråga
			"Fëanor dies fighting a host of Balrogs", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1497, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			89, // Id
			"Lord of The Rings", // Kategori
			"The Noldor are banished from Valinor", // Fråga
			"Most of the Noldor are subsequently given the chance to repent, except for Fëanor and his sons", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1496, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			90, // Id
			"Lord of The Rings", // Kategori
			"Destruction of the Two Trees", // Fråga
			"Ungoliant sucks the light out fo the Trees and poisons them in the process", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1495, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			91, // Id
			"Lord of The Rings", // Kategori
			"Morgoth steals the three Silmarils", // Fråga
			"", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1495, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			92, // Id
			"Lord of The Rings", // Kategori
			"The first kinslaying", // Fråga
			"There were a total of three kinslaying among elves during the first age", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1495, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			93, // Id
			"Lord of The Rings", // Kategori
			"Fëanor makes the Silmarils", // Fråga
			"The Silmarils are imbued with the light of the Two Trees and are said to be the greatest creations by any living", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1450, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			94, // Id
			"Lord of The Rings", // Kategori
			"Morgoth is released from the halls of Mandos", // Fråga
			"Morgoth promises to play nice (spoiler alert: He doesn't)", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1400, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			95, // Id
			"Lord of The Rings", // Kategori
			"Galadriel is born", // Fråga
			"The name Galadriel literally means \"maiden crowned with a garland of bright radiance\" as a reference to her golden hair", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1362, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			96, // Id
			"Lord of The Rings", // Kategori
			"Birth of Fëanor", // Fråga
			"Fëanor is cited as the greatest craftsman and most gifted of all who have ever lived", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Extreme, //Svårighetsgrad
			1169, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			97, // Id
			"Lord of The Rings", // Kategori
			"Morgoth is brought back to Valinor in chains and imprisoned in the Halls of Mandos.", // Fråga
			"Morgoths original name was Melkor, the name Morgoth (Black Foe of the World) was given to him by Fëanor", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1100, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			98, // Id
			"Lord of The Rings", // Kategori
			"Yavanna creates the Two Trees", // Fråga
			"Before the Sun and the Moon these two trees shone of silver and gold", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			99, // Id
			"Lord of The Rings", // Kategori
			"Varda creates the first stars", // Fråga
			"Varda is most beloved out of all the Valar by the Elves. Many might know her by the name \"Elbereth, Queen of the Stars\"", // Trivia
			null, // WikiUrl
			Ages.trees, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			1000, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		),
		new LotrCardModel(
			100, // Id
			"Lord of The Rings", // Kategori
			"Music of the Ainur, creation of the material universe", // Fråga
			"The universe was sung in to existence by all the Valar. During the music Morgoth rebelled and tried to make his own music", // Trivia
			null, // WikiUrl
			Ages.beforeDays, // Tidsålder
			DifficultyRating.Hard, //Svårighetsgrad
			0, // År
			null, // Månad
			null, // Dag
			false, // Händer det i Lotr eller the hobbit?
			null // Är det ett "great happening" som ska vara med i alla quiz?

		)
		);
		}
	}
}
