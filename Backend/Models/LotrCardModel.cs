using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Models
{
	public class LotrCardModel
	{
		public int Id { get; set; }
		public string Category { get; set; }
		public string Question { get; set; }
		public string? Trivia { get; set; }
		public string? WikiUrl { get; set; }
		public Ages Age { get; set; }
		public DifficultyRating Difficulty { get; set; }

		public string? ImageUrl { get; set; }

		public int Year { get; set; }
		public int? Month { get; set; }
		public int? Day { get; set; }

		[Column(TypeName = "decimal(18,3)")]
		public decimal TimeValue { get; set; }

		// Should this event be on the Lotr/The Hobbit quiz?
		public bool IsLotrOrTheHobbit { get; set; }

		// Is this event so important it should show up on all quizes? (only applies if isLotrOrTheHobbit is true)
		public bool? IsGreatHappening { get; set; }

		public LotrCardModel(int id, string category, string question, string? imageUrl, string? trivia, string? wikiUrl, Ages age, int year, int? month, int? day, bool isLotrOrTheHobbit, bool? isGreatHappening)
		{
			Id = id;
			Category = category;
			Question = question;
			ImageUrl = imageUrl;
			Trivia = trivia;
			WikiUrl = wikiUrl;
			Age = age;
			Year = year;
			Month = month;
			Day = day;
			IsLotrOrTheHobbit = isLotrOrTheHobbit;
			IsGreatHappening = isGreatHappening;

			TimeValue = CalculateTimeValue(Age, Year, Month, Day);
		}

		private decimal CalculateTimeValue(Ages age, int year, int? month, int? day)
		{
			decimal timeValue = 0;
			timeValue += (int)age;
			timeValue += year;
			if (month != null && day != null)
			{
				day = (month * 30) - 30 + day;
				timeValue = timeValue + ((decimal)day / 1000);

			}

			return timeValue;
		}
	}
}
